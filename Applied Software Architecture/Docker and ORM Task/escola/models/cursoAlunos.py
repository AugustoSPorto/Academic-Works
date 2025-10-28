from sqlalchemy import String, Integer, Column, TIMESTAMP, text, ForeignKey
from .database import Base

class CursoAlunos(Base):
    __tablename__ = 'cursoAlunos'
    
    id = Column(Integer, primary_key=True, autoincrement=True)
    curso_id = Column(Integer, ForeignKey('cursos.id'), nullable=False)
    aluno_id = Column(Integer, ForeignKey('alunos.id'), nullable=False)
    added_at = Column(TIMESTAMP(timezone=True), nullable=False, server_default=text('Now()'))

