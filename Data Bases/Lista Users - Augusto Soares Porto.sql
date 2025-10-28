--			Lista Users
-- 	Aluno: Augusto Soares Porto - 12121ECP016

-- Seja o seguinte grupo de usuários de um sistema:
-- Gerente: Esse grupo de usuário tem a permissão de modificar todos os registros de todas as tabelas, além de utilizar as rotinas (stored procedures), além de poder dar direitos aos outros usuários

CREATE USER gerente WITH PASSWORD 'gerente_senha';
GRANT ALL PRIVILEGES ON ALL TABLES IN SCHEMA public TO gerente;
GRANT ALL PRIVILEGES ON ALL SEQUENCES IN SCHEMA aulas TO gerente;
GRANT ALL PRIVILEGES ON ALL FUNCTIONS IN SCHEMA aulas TO gerente;
GRANT gerente TO postgres;

-- Analista: Esse grupo possui permissão de modificar registros, mas não pode acessar nenhuma rotina, não pode criar base de dados e não pode criar tabelas

CREATE USER analista WITH PASSWORD 'analista_senha';
GRANT SELECT, INSERT, UPDATE, DELETE ON ALL TABLES IN SCHEMA public TO analista;
GRANT USAGE, SELECT ON ALL SEQUENCES IN SCHEMA aulas TO analista;

-- Estagiário: Esse grupo pode apenas visualizar informações (apenas comandos SELECT)
CREATE USER estagiario WITH PASSWORD 'estagiario_senha';
GRANT SELECT ON ALL TABLES IN SCHEMA public TO estagiario;
GRANT SELECT ON ALL SEQUENCES IN SCHEMA aulas TO estagiario;

