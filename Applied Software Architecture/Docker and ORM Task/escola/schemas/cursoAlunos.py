from pydantic import BaseModel

class CursoAluno(BaseModel):
    curso_id: int
    aluno_id: int