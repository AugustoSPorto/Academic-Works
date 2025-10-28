
### arquivo models/cursoAlunos.py ###
from fastapi                import APIRouter, Depends, HTTPException, Response, status
from schemas.cursoAlunos    import CursoAluno
from models.database        import get_db
from models.cursoAlunos     import CursoAlunos
from sqlalchemy.orm         import Session
import logging

logging.basicConfig(level=logging.INFO, format='%(asctime)s - %(levelname)s - %(message)s')


router = APIRouter()

@router.get("/cursoAlunos")
def get(db: Session = Depends(get_db)):
    all_cursoAlunos = db.query(CursoAlunos).all()
    logging.info("GET_ALL_CURSOALUNOS")
    cursoAlunos = []
    for cursoAlunos in all_cursoAlunos:
        item = {"curso_id": cursoAlunos.curso_id,
                "aluno_id": cursoAlunos.aluno_id}
        cursoAlunos.append(item)       
    logging.info(cursoAlunos)
    return all_cursoAlunos


@router.post("/cursoAlunos")
async def criar_cursoAlunos(cursoAlunos: CursoAluno, db: Session = Depends(get_db)):
    novo_cursoAlunos = CursoAlunos(**cursoAlunos.model_dump())
    try:
        
        db.add(novo_cursoAlunos)
        db.commit()
        db.refresh(novo_cursoAlunos)
        logging.info("CursoAluno criado com sucesso")
        return { "mensagem": "CursoAluno criado com sucesso",
                 "cursoAlunos": novo_cursoAlunos}
    except Exception as e:
            logging.error(e)
            return { "mensagem": "Problemas para inserir o cursoAlunos",
                 "cursoAlunos": novo_cursoAlunos}
 
@router.delete("/cursoAlunos/{curso_id}")
def delete(id:int ,db: Session = Depends(get_db), status_code = status.HTTP_204_NO_CONTENT):
    delete_post = db.query(CursoAlunos).filter(CursoAlunos.curso_id == id)
    
    if delete_post == None:
        raise HTTPException(status_code=status.HTTP_404_NOT_FOUND, detail=f"Curso não existe")
    else:
        delete_post.delete(synchronize_session=False)
        db.commit()
    return Response(status_code=status.HTTP_204_NO_CONTENT)   


@router.put("/cursoAlunos/{curso_id}")
def update(id: int, cursoAlunos:CursoAluno, db:Session = Depends(get_db)):
    updated_post = db.query(CursoAlunos).filter(CursoAlunos.curso_id == id)
    updated_post.first()
    if updated_post == None:
        raise HTTPException(status_code=status.HTTP_404_NOT_FOUND, detail=f'Curso: {id} does not exist')
    else:
        updated_post.update(cursoAlunos.model_dump(), synchronize_session=False)
        db.commit()
    return updated_post.first()

