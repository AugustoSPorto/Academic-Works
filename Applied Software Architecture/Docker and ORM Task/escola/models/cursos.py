from sqlalchemy import String, Integer, Column, TIMESTAMP, text, ForeignKey
from .database import Base

class Cursos(Base):
    __tablename__ = 'cursos'

    id = Column(Integer, primary_key=True, autoincrement=True)
    nome = Column(String(45), nullable=False)
    professor_id = Column(Integer, ForeignKey('professores.id'), nullable=False)  
    added_at = Column(TIMESTAMP(timezone=True), nullable=False, server_default=text('Now()'))
