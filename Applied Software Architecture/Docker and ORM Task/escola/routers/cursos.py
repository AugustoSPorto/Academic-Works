
### arquivo models/cursos.py ###
from fastapi          import APIRouter, Depends, HTTPException, Response, status
from schemas.cursos   import Curso
from models.database  import get_db
from models.cursos    import Cursos
from sqlalchemy.orm   import Session
import logging

logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s')


router = APIRouter()

@router.get("/cursos")
def get(db: Session = Depends(get_db)):
    all_cursos = db.query(Cursos).all()
    logging.info("GET_ALL_CURSOS")
    cursos = []
    for curso in all_cursos:
        item = {"id": curso.id,
                "nome": curso.nome}
        cursos.append(item)       
    logging.info(cursos)
    return all_cursos


@router.post("/cursos")
async def criar_curso(curso: Curso, db: Session = Depends(get_db)):
    novo_curso = Cursos(**curso.model_dump())
    try:
        
        db.add(novo_curso)
        db.commit()
        db.refresh(novo_curso)
        logging.info("Curso criado com sucesso")
        return { "mensagem": "Curso criado com sucesso",
                 "curso": novo_curso}
    except Exception as e:
            logging.error(e)
            return { "mensagem": "Problemas para inserir o curso",
                 "curso": novo_curso}
 
@router.delete("/cursos/{id}")
def delete(id:int ,db: Session = Depends(get_db), status_code = status.HTTP_204_NO_CONTENT):
    delete_post = db.query(Cursos).filter(Cursos.id == id)
    
    if delete_post == None:
        raise HTTPException(status_code=status.HTTP_404_NOT_FOUND, detail=f"Curso não existe")
    else:
        delete_post.delete(synchronize_session=False)
        db.commit()
    return Response(status_code=status.HTTP_204_NO_CONTENT)   


@router.put("/cursos/{id}")
def update(id: int, curso:Curso, db:Session = Depends(get_db)):
    updated_post = db.query(Cursos).filter(Cursos.id == id)
    updated_post.first()
    if updated_post == None:
        raise HTTPException(status_code=status.HTTP_404_NOT_FOUND, detail=f'Curso: {id} does not exist')
    else:
        updated_post.update(curso.model_dump(), synchronize_session=False)
        db.commit()
    return updated_post.first()

