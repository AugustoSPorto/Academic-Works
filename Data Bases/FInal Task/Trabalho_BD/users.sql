-- Gerente: Possui todas as permissões em todas as tabelas, sequências e funções
CREATE ROLE gerente;

CREATE USER gerente01 WITH PASSWORD 'gerente01' IN ROLE gerente;
CREATE USER gerente02 WITH PASSWORD 'gerente02' IN ROLE gerente;

-- Conceder permissões para o usuário 'gerente' em todos os schemas
DO $$
DECLARE
  rec RECORD;
BEGIN
  FOR rec IN (SELECT schema_name FROM information_schema.schemata) LOOP
    EXECUTE format('GRANT USAGE ON SCHEMA %I TO gerente', rec.schema_name);
	EXECUTE format('GRANT ALL PRIVILEGES ON ALL TABLES IN SCHEMA %I TO gerente', rec.schema_name);
    EXECUTE format('GRANT ALL PRIVILEGES ON ALL SEQUENCES IN SCHEMA %I TO gerente', rec.schema_name);
    EXECUTE format('GRANT ALL PRIVILEGES ON ALL FUNCTIONS IN SCHEMA %I TO gerente', rec.schema_name);
  END LOOP;
END $$;

-- Analista: Permissão para modificar registros, mas sem acesso a rotinas, criação de tabelas ou bases de dados
CREATE ROLE analista;

CREATE USER analista01 WITH PASSWORD 'analista01' IN ROLE analista;
CREATE USER analista02 WITH PASSWORD 'analista02' IN ROLE analista;

-- Conceder permissões para o usuário 'analista' em todos os schemas
DO $$
DECLARE
  rec RECORD;
BEGIN
  FOR rec IN (SELECT schema_name FROM information_schema.schemata) LOOP
  	EXECUTE format('GRANT USAGE ON SCHEMA %I TO analista', rec.schema_name);
    EXECUTE format('GRANT SELECT, INSERT, UPDATE, DELETE ON ALL TABLES IN SCHEMA %I TO analista', rec.schema_name);
    EXECUTE format('GRANT USAGE, SELECT ON ALL SEQUENCES IN SCHEMA %I TO analista', rec.schema_name);
  END LOOP;
END $$;

-- Estagiário: Apenas acesso para visualizar dados (comando SELECT)
CREATE ROLE estagiario;

CREATE USER estagiario01 WITH PASSWORD 'estagiario01' IN ROLE estagiario;
CREATE USER estagiario02 WITH PASSWORD 'estagiario02' IN ROLE estagiario;

-- Conceder permissões para o usuário 'estagiario' em todos os schemas
DO $$
DECLARE
  rec RECORD;
BEGIN
  FOR rec IN (SELECT schema_name FROM information_schema.schemata) LOOP
  	EXECUTE format('GRANT USAGE ON SCHEMA %I TO estagiario', rec.schema_name);
    EXECUTE format('GRANT SELECT ON ALL TABLES IN SCHEMA %I TO estagiario', rec.schema_name);
    EXECUTE format('GRANT SELECT ON ALL SEQUENCES IN SCHEMA %I TO estagiario', rec.schema_name);
  END LOOP;
END $$;
