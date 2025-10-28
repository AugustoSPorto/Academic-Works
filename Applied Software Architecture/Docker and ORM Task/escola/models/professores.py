from sqlalchemy import String, Integer, Column, TIMESTAMP, text, ForeignKey
from .database import Base

class Professores(Base):
    __tablename__ = 'professores'

    id = Column(Integer, primary_key=True, autoincrement=True)
    nome = Column(String(45), nullable=False)
    email = Column(String(45), nullable=False)
    cpf = Column(String(45), nullable=False)
    endereco = Column(String(45))
    numero = Column(Integer, nullable=False)
    complemento = Column(String(45), nullable=False)
    cidade = Column(String(45))
    estado = Column(String(45))
    added_at = Column(TIMESTAMP(timezone=True), nullable=False, server_default=text('Now()'))