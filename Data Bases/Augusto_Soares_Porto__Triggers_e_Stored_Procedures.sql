-- 			Tarefas de Triggers e Stored Procedures
-- Aluno: Augusto Soares Porto - 12121ECP016

-- Criar uma função que mostre a quantidade de cidades existentes no Brasil e no estado de Minas Gerais
CREATE OR REPLACE FUNCTION public.fn_mostrar_num_cidades()
RETURNS VARCHAR AS
$$
	DECLARE
		num_brasil INT;
		num_minas INT;
	BEGIN
		SELECT COUNT(*) INTO num_brasil FROM public.localidades;
		SELECT COUNT(*) INTO num_minas FROM public.localidades WHERE estado = 'MG';
		RETURN 'Numero de cidades no Brasil: ' || num_brasil || ' e Numero de cidades em Minas Gerais: ' || num_minas;
	END
$$
LANGUAGE plpgsql;

-- Criar uma função que liste as cidades do estado de Minas Gerais
CREATE OR REPLACE FUNCTION public.fn_lista_minas()
RETURNS SETOF public.localidades AS
$$
	SELECT * FROM public.localidades WHERE estado = 'MG';
$$
LANGUAGE SQL;

-- Criar uma função que liste todas as ruas da cidade de Uberlândia
CREATE OR REPLACE FUNCTION public.fn_lista_uberlandia()
RETURNS SETOF public.logradouros AS
$$
DECLARE
    id_uberlandia INT;
BEGIN
    SELECT codigo INTO id_uberlandia FROM public.localidades WHERE localidade = 'Uberlândia';
    RETURN QUERY SELECT * FROM public.logradouros WHERE localidade = id_uberlandia AND tipo = 'Rua';
END
$$
LANGUAGE plpgsql;


-- Criar uma função que permita que o usuário insira, altere e remova registros da tabela de localidades
CREATE OR REPLACE FUNCTION public.gerenciar_localidade(
	p_operacao	VARCHAR,
	p_codigo	INT,
	p_localidade	VARCHAR,
	p_estado	VARCHAR)
RETURNS VOID AS
$$
BEGIN
    IF p_operacao = 'inserir' THEN
        INSERT INTO public.localidades(codigo, localidade, estado) 
		VALUES (p_codigo, p_localidade, p_estado);
    ELSIF p_operacao = 'atualizar' THEN
        UPDATE public.localidades SET localidade = p_localidade, estado = p_estado 
		WHERE codigo = p_codigo;
    ELSIF p_operacao = 'remover' THEN
        DELETE FROM public.localidades 
		WHERE codigo = p_codigo;
    END IF;
END
$$ LANGUAGE plpgsql;

-- Criar uma trigger responsável pela auditoria das informações da tabela de localidades
CREATE TABLE public.tb_localidades_auditoria (
	operacao 	CHAR NOT NULL,
	usuario 	VARCHAR NOT NULL,
	dt_hr 		TIMESTAMP NOT NULL,
	codigo		INT,
	localidade	VARCHAR,
	estado		VARCHAR);

CREATE OR REPLACE FUNCTION public.fn_localidades_auditoria()
RETURNS TRIGGER AS
$$
	BEGIN
    	IF (TG_OP = 'DELETE') THEN
           	INSERT INTO public.tb_localidades_auditoria
            SELECT 'e', user, NOW(), old.*;
            RETURN old;
    	ELSIF (TG_OP = 'UPDATE') THEN
           	INSERT INTO public.tb_localidades_auditoria
            SELECT 'a', user, NOW(), new.*;
            RETURN new;
    	ELSIF (TG_OP = 'INSERT') THEN
           	INSERT INTO public.tb_localidades_auditoria
            SELECT 'i', user, NOW(), new.*;
            RETURN new;
        END IF;
        RETURN NULL;                   
    END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_localidades_auditoria
AFTER INSERT OR UPDATE OR DELETE ON public.localidades
FOR EACH ROW EXECUTE FUNCTION public.fn_localidades_auditoria();