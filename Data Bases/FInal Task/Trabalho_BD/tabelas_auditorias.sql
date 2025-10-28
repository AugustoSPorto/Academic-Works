--		HUMANRESOURCES
--employee
CREATE TABLE humanresources.tb_employee_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_businessentityid INTEGER, 
    p_nationalidnumber VARCHAR(15), 
    p_loginid VARCHAR(256), 
    p_jobtitle VARCHAR(50), 
    p_birthdate DATE, 
    p_maritalstatus CHARACTER, 
    p_gender CHARACTER, 
    p_hiredate DATE, 
    p_salariedflag BOOLEAN, 
    p_vacationhours INTEGER, 
    p_sickleavehours INTEGER, 
    p_currentflag BOOLEAN, 
    p_orgnode VARCHAR);

CREATE OR REPLACE FUNCTION humanresources.fn_employee_auditoria()
RETURNS trigger AS
$$
BEGIN
    	IF(tg_op = 'DELETE') THEN
           	INSERT INTO humanresources.tb_employee_auditoria
            SELECT 'E', user, now(),OLD.*;
            RETURN OLD;
    	ELSIF(tg_op = 'UPDATE') THEN
           	INSERT INTO humanresources.tb_employee_auditoria
            SELECT 'A', user, now(),NEW.*;
            RETURN NEW;
    	ELSIF(tg_op = 'INSERT') THEN
           	INSERT INTO humanresources.tb_employee_auditoria
            SELECT 'I', user, now(),NEW.*;
            RETURN NEW;
        END IF;
        RETURN NULL;                   
    END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_empregado_auditoria
AFTER INSERT OR UPDATE OR DELETE ON humanresources.tb_employee_auditoria
FOR EACH ROW EXECUTE PROCEDURE humanresources.fn_employee_auditoria();


--		PERSON
-- address
CREATE TABLE person.tb_address_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_addressline1 VARCHAR(60), 
    p_addressline2 VARCHAR(60), 
    p_city VARCHAR(30), 
    p_stateprovinceid INTEGER, 
    p_postalcode VARCHAR(15), 
    p_spatiallocation BYTEA);

CREATE OR REPLACE FUNCTION person.fn_address_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO person.tb_address_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO person.tb_address_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO person.tb_address_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_address_auditoria
AFTER INSERT OR UPDATE OR DELETE ON person.tb_address_auditoria
FOR EACH ROW EXECUTE PROCEDURE person.fn_address_auditoria();

-- businessentity
CREATE TABLE person.tb_businessentity_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL);

CREATE OR REPLACE FUNCTION person.fn_businessentity_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO person.tb_businessentity_auditoria
        SELECT 'E', user, NOW();
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO person.tb_businessentity_auditoria
        SELECT 'A', user, NOW();
        RETURN NULL;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO person.tb_businessentity_auditoria
        SELECT 'I', user, NOW();
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_businessentity_auditoria
AFTER INSERT OR UPDATE OR DELETE ON person.tb_businessentity_auditoria
FOR EACH ROW EXECUTE PROCEDURE person.fn_businessentity_auditoria();

-- countryregion
CREATE TABLE person.tb_countryregion_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_countryregioncode VARCHAR(3), 
    p_name VARCHAR(50));

CREATE OR REPLACE FUNCTION person.fn_countryregion_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO person.tb_countryregion_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO person.tb_countryregion_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO person.tb_countryregion_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_countryregion_auditoria
AFTER INSERT OR UPDATE OR DELETE ON person.tb_countryregion_auditoria
FOR EACH ROW EXECUTE PROCEDURE person.fn_countryregion_auditoria();

-- emailaddress
CREATE TABLE person.tb_emailaddress_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_businessentityid INTEGER, 
    p_emailaddress VARCHAR(50));

CREATE OR REPLACE FUNCTION person.fn_emailaddress_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO person.tb_emailaddress_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO person.tb_emailaddress_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO person.tb_emailaddress_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_emailaddress_auditoria
AFTER INSERT OR UPDATE OR DELETE ON person.tb_emailaddress_auditoria
FOR EACH ROW EXECUTE PROCEDURE person.fn_emailaddress_auditoria();

-- password
CREATE TABLE person.tb_password_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_businessentityid INTEGER, 
    p_passwordhash VARCHAR(128), 
    p_passwordsalt VARCHAR(10));

CREATE OR REPLACE FUNCTION person.fn_password_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO person.tb_password_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO person.tb_password_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO person.tb_password_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_password_auditoria
AFTER INSERT OR UPDATE OR DELETE ON person.tb_password_auditoria
FOR EACH ROW EXECUTE PROCEDURE person.fn_password_auditoria();

-- person
CREATE TABLE person.tb_person_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_businessentityid INTEGER, 
    p_persontype CHARACTER, 
    p_namestyle BOOLEAN, 
    p_title VARCHAR(8), 
    p_firstname VARCHAR(50), 
    p_middlename VARCHAR(50), 
    p_lastname VARCHAR(50), 
    p_suffix VARCHAR(10), 
    p_emailpromotion INTEGER, 
    p_additionalcontactinfo XML, 
    p_demographics XML);

CREATE OR REPLACE FUNCTION person.fn_person_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO person.tb_person_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO person.tb_person_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO person.tb_person_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_person_auditoria
AFTER INSERT OR UPDATE OR DELETE ON person.tb_person_auditoria
FOR EACH ROW EXECUTE PROCEDURE person.fn_person_auditoria();

-- personphone
CREATE TABLE person.tb_personphone_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_businessentityid INTEGER, 
    p_phonenumber VARCHAR(25), 
    p_phonenumbertypeid INTEGER);

CREATE OR REPLACE FUNCTION person.fn_personphone_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO person.tb_personphone_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO person.tb_personphone_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO person.tb_personphone_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_personphone_auditoria
AFTER INSERT OR UPDATE OR DELETE ON person.tb_personphone_auditoria
FOR EACH ROW EXECUTE PROCEDURE person.fn_personphone_auditoria();

-- phonenumbertype
CREATE TABLE person.tb_phonenumbertype_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_name VARCHAR(50));

CREATE OR REPLACE FUNCTION person.fn_phonenumbertype_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO person.tb_phonenumbertype_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO person.tb_phonenumbertype_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO person.tb_phonenumbertype_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_phonenumbertype_auditoria
AFTER INSERT OR UPDATE OR DELETE ON person.tb_phonenumbertype_auditoria
FOR EACH ROW EXECUTE PROCEDURE person.fn_phonenumbertype_auditoria();

-- stateprovince
CREATE TABLE person.tb_stateprovince_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_stateprovincecode CHARACTER, 
    p_countryregioncode VARCHAR(3), 
    p_isonlystateprovinceflag BOOLEAN, 
    p_name VARCHAR(50), 
    p_territoryid INTEGER);

CREATE OR REPLACE FUNCTION person.fn_stateprovince_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO person.tb_stateprovince_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO person.tb_stateprovince_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO person.tb_stateprovince_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_stateprovince_auditoria
AFTER INSERT OR UPDATE OR DELETE ON person.tb_stateprovince_auditoria
FOR EACH ROW EXECUTE PROCEDURE person.fn_stateprovince_auditoria();


--		PRODUCTION
-- product
CREATE TABLE production.tb_product_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_name VARCHAR(50), 
    p_productnumber VARCHAR(25), 
    p_makeflag BOOLEAN, 
    p_finishedgoodsflag BOOLEAN, 
    p_color VARCHAR(15), 
    p_safetystocklevel INTEGER, 
    p_reorderpoint INTEGER, 
    p_standardcost NUMERIC, 
    p_listprice NUMERIC, 
    p_size VARCHAR(5), 
    p_sizeunitmeasurecode CHARACTER, 
    p_weightunitmeasurecode CHARACTER, 
    p_weight NUMERIC(8,2), 
    p_daystomanufacture INTEGER, 
    p_productline CHARACTER, 
    p_class CHARACTER, 
    p_style CHARACTER, 
    p_productsubcategoryid INTEGER, 
    p_productmodelid INTEGER, 
    p_sellstartdate TIMESTAMP, 
    p_sellenddate TIMESTAMP, 
    p_discontinueddate TIMESTAMP);

CREATE OR REPLACE FUNCTION production.fn_product_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO production.tb_product_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO production.tb_product_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO production.tb_product_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_product_auditoria
AFTER INSERT OR UPDATE OR DELETE ON production.tb_product_auditoria
FOR EACH ROW EXECUTE PROCEDURE production.fn_product_auditoria();

-- productcategory
CREATE TABLE production.tb_productcategory_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_name VARCHAR(50));

CREATE OR REPLACE FUNCTION production.fn_productcategory_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO production.tb_productcategory_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO production.tb_productcategory_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO production.tb_productcategory_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_productcategory_auditoria
AFTER INSERT OR UPDATE OR DELETE ON production.tb_productcategory_auditoria
FOR EACH ROW EXECUTE PROCEDURE production.fn_productcategory_auditoria();

-- productmodel
CREATE TABLE production.tb_productmodel_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_name VARCHAR(50), 
    p_catalogdescription XML, 
    p_instructions XML);

CREATE OR REPLACE FUNCTION production.fn_productmodel_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO production.tb_productmodel_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO production.tb_productmodel_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO production.tb_productmodel_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_productmodel_auditoria
AFTER INSERT OR UPDATE OR DELETE ON production.tb_productmodel_auditoria
FOR EACH ROW EXECUTE PROCEDURE production.fn_productmodel_auditoria();

-- productsubcategory
CREATE TABLE production.tb_productsubcategory_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_productcategoryid INTEGER, 
    p_name VARCHAR(50));

CREATE OR REPLACE FUNCTION production.fn_productsubcategory_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO production.tb_productsubcategory_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO production.tb_productsubcategory_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO production.tb_productsubcategory_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_productsubcategory_auditoria
AFTER INSERT OR UPDATE OR DELETE ON production.tb_productsubcategory_auditoria
FOR EACH ROW EXECUTE PROCEDURE production.fn_productsubcategory_auditoria();

-- transactionhistory
CREATE TABLE production.tb_transactionhistory_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_productid INTEGER, 
    p_referenceorderid INTEGER, 
    p_referenceorderlineid INTEGER, 
    p_transactiondate TIMESTAMP, 
    p_transactiontype CHARACTER, 
    p_quantity INTEGER, 
    p_actualcost NUMERIC);

CREATE OR REPLACE FUNCTION production.fn_transactionhistory_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO production.tb_transactionhistory_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO production.tb_transactionhistory_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO production.tb_transactionhistory_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_transactionhistory_auditoria
AFTER INSERT OR UPDATE OR DELETE ON production.tb_transactionhistory_auditoria
FOR EACH ROW EXECUTE PROCEDURE production.fn_transactionhistory_auditoria();

-- unitmeasure
CREATE TABLE production.tb_unitmeasure_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_unitmeasurecode CHARACTER, 
    p_name VARCHAR(50));

CREATE OR REPLACE FUNCTION production.fn_unitmeasure_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO production.tb_unitmeasure_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO production.tb_unitmeasure_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO production.tb_unitmeasure_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_unitmeasure_auditoria
AFTER INSERT OR UPDATE OR DELETE ON production.tb_unitmeasure_auditoria
FOR EACH ROW EXECUTE PROCEDURE production.fn_unitmeasure_auditoria();


--		 PURCHASING
-- productvendor
CREATE TABLE purchasing.tb_productvendor_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_productid INTEGER, 
    p_businessentityid INTEGER, 
    p_averageleadtime INTEGER, 
    p_standardprice NUMERIC, 
    p_lastreceiptcost NUMERIC, 
    p_lastreceiptdate TIMESTAMP, 
    p_minorderqty INTEGER, 
    p_maxorderqty INTEGER, 
    p_onorderqty INTEGER, 
    p_unitmeasurecode CHARACTER
);

CREATE OR REPLACE FUNCTION purchasing.fn_productvendor_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO purchasing.tb_productvendor_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO purchasing.tb_productvendor_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO purchasing.tb_productvendor_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_productvendor_auditoria
AFTER INSERT OR UPDATE OR DELETE ON purchasing.tb_productvendor_auditoria
FOR EACH ROW EXECUTE PROCEDURE purchasing.fn_productvendor_auditoria();

-- purchaseorderdetail
CREATE TABLE purchasing.tb_purchaseorderdetail_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_purchaseorderid INTEGER, 
    p_duedate TIMESTAMP, 
    p_orderqty INTEGER, 
    p_productid INTEGER, 
    p_unitprice NUMERIC, 
    p_receivedqty NUMERIC(8,2), 
    p_rejectedqty NUMERIC(8,2)
);

CREATE OR REPLACE FUNCTION purchasing.fn_purchaseorderdetail_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO purchasing.tb_purchaseorderdetail_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO purchasing.tb_purchaseorderdetail_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO purchasing.tb_purchaseorderdetail_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_purchaseorderdetail_auditoria
AFTER INSERT OR UPDATE OR DELETE ON purchasing.tb_purchaseorderdetail_auditoria
FOR EACH ROW EXECUTE PROCEDURE purchasing.fn_purchaseorderdetail_auditoria();

-- purchaseorderheader
CREATE TABLE purchasing.tb_purchaseorderheader_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_revisionnumber INTEGER, 
    p_status INTEGER, 
    p_employeeid INTEGER, 
    p_vendorid INTEGER, 
    p_shipmethod INTEGER, 
    p_orderdate TIMESTAMP, 
    p_shipdate TIMESTAMP, 
    p_subtotal NUMERIC, 
    p_taxamt NUMERIC, 
    p_freight NUMERIC
);

CREATE OR REPLACE FUNCTION purchasing.fn_purchaseorderheader_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO purchasing.tb_purchaseorderheader_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO purchasing.tb_purchaseorderheader_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO purchasing.tb_purchaseorderheader_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_purchaseorderheader_auditoria
AFTER INSERT OR UPDATE OR DELETE ON purchasing.tb_purchaseorderheader_auditoria
FOR EACH ROW EXECUTE PROCEDURE purchasing.fn_purchaseorderheader_auditoria();

-- shipmethod
CREATE TABLE purchasing.tb_shipmethod_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_name VARCHAR(50), 
    p_shipbase NUMERIC, 
    p_shiprate NUMERIC
);

CREATE OR REPLACE FUNCTION purchasing.fn_shipmethod_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO purchasing.tb_shipmethod_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO purchasing.tb_shipmethod_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO purchasing.tb_shipmethod_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_shipmethod_auditoria
AFTER INSERT OR UPDATE OR DELETE ON purchasing.tb_shipmethod_auditoria
FOR EACH ROW EXECUTE PROCEDURE purchasing.fn_shipmethod_auditoria();

-- vendor
CREATE TABLE purchasing.tb_vendor_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_businessentityid INTEGER, 
    p_accountnumber VARCHAR(15), 
    p_name VARCHAR(50), 
    p_creditrating INTEGER, 
    p_preferredvendorstatus BOOLEAN, 
    p_activeflag BOOLEAN, 
    p_purchasingwebserviceurl VARCHAR(1024)
);

CREATE OR REPLACE FUNCTION purchasing.fn_vendor_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO purchasing.tb_vendor_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO purchasing.tb_vendor_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO purchasing.tb_vendor_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_vendor_auditoria
AFTER INSERT OR UPDATE OR DELETE ON purchasing.tb_vendor_auditoria
FOR EACH ROW EXECUTE PROCEDURE purchasing.fn_vendor_auditoria();


-- SALES
-- creditcard
CREATE TABLE sales.tb_creditcard_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_cardtype VARCHAR(50), 
    p_cardnumber VARCHAR(25), 
    p_expmonth INTEGER, 
    p_expyear INTEGER
);

CREATE OR REPLACE FUNCTION sales.fn_creditcard_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO sales.tb_creditcard_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO sales.tb_creditcard_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO sales.tb_creditcard_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_creditcard_auditoria
AFTER INSERT OR UPDATE OR DELETE ON sales.tb_creditcard_auditoria
FOR EACH ROW EXECUTE PROCEDURE sales.fn_creditcard_auditoria();

-- customer
CREATE TABLE sales.tb_customer_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_personid INTEGER, 
    p_storeid INTEGER, 
    p_territoryid INTEGER
);

CREATE OR REPLACE FUNCTION sales.fn_customer_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO sales.tb_customer_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO sales.tb_customer_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO sales.tb_customer_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_customer_auditoria
AFTER INSERT OR UPDATE OR DELETE ON sales.tb_customer_auditoria
FOR EACH ROW EXECUTE PROCEDURE sales.fn_customer_auditoria();

-- personcreditcard
CREATE TABLE sales.tb_personcreditcard_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_businessentityid INTEGER, 
    p_creditcardid INTEGER
);

CREATE OR REPLACE FUNCTION sales.fn_personcreditcard_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO sales.tb_personcreditcard_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO sales.tb_personcreditcard_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO sales.tb_personcreditcard_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_personcreditcard_auditoria
AFTER INSERT OR UPDATE OR DELETE ON sales.tb_personcreditcard_auditoria
FOR EACH ROW EXECUTE PROCEDURE sales.fn_personcreditcard_auditoria();

-- salesorderdetail
CREATE TABLE sales.tb_salesorderdetail_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_salesorderid INTEGER, 
    p_carriertrackingnumber VARCHAR(25), 
    p_orderqty INTEGER, 
    p_productid INTEGER, 
    p_specialofferid INTEGER, 
    p_unitprice NUMERIC, 
    p_unitpricediscount NUMERIC
);

CREATE OR REPLACE FUNCTION sales.fn_salesorderdetail_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO sales.tb_salesorderdetail_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO sales.tb_salesorderdetail_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO sales.tb_salesorderdetail_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_salesorderdetail_auditoria
AFTER INSERT OR UPDATE OR DELETE ON sales.tb_salesorderdetail_auditoria
FOR EACH ROW EXECUTE PROCEDURE sales.fn_salesorderdetail_auditoria();

-- salesorderheader
CREATE TABLE sales.tb_salesorderheader_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_revisionnumber INTEGER, 
    p_orderdate TIMESTAMP, 
    p_duedate TIMESTAMP, 
    p_shipdate TIMESTAMP, 
    p_status INTEGER, 
    p_onlineorderflag BOOLEAN, 
    p_purchaseordernumber VARCHAR(25), 
    p_accountnumber VARCHAR(15), 
    p_customerid INTEGER, 
    p_salespersonid INTEGER, 
    p_territoryid INTEGER, 
    p_billtoaddressid INTEGER, 
    p_shiptoaddressid INTEGER, 
    p_shipmethodid INTEGER, 
    p_creditcardid INTEGER, 
    p_creditcardapprovalcode VARCHAR(15), 
    p_currencyrateid INTEGER, 
    p_subtotal NUMERIC, 
    p_taxamt NUMERIC, 
    p_freight NUMERIC, 
    p_totaldue NUMERIC, 
    p_commentary VARCHAR(128)
);

CREATE OR REPLACE FUNCTION sales.fn_salesorderheader_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO sales.tb_salesorderheader_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO sales.tb_salesorderheader_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO sales.tb_salesorderheader_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_salesorderheader_auditoria
AFTER INSERT OR UPDATE OR DELETE ON sales.tb_salesorderheader_auditoria
FOR EACH ROW EXECUTE PROCEDURE sales.fn_salesorderheader_auditoria();

-- salesperson
CREATE TABLE sales.tb_salesperson_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_businessentityid INTEGER, 
    p_territoryid INTEGER, 
    p_salesquota NUMERIC, 
    p_bonus NUMERIC, 
    p_commissionpct NUMERIC, 
    p_salesytd NUMERIC, 
    p_saleslastyear NUMERIC
);

CREATE OR REPLACE FUNCTION sales.fn_salesperson_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO sales.tb_salesperson_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO sales.tb_salesperson_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO sales.tb_salesperson_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_salesperson_auditoria
AFTER INSERT OR UPDATE OR DELETE ON sales.tb_salesperson_auditoria
FOR EACH ROW EXECUTE PROCEDURE sales.fn_salesperson_auditoria();

-- salesterritory
CREATE TABLE sales.tb_salesterritory_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_name VARCHAR(50), 
    p_countryregioncode VARCHAR(3), 
    p_grp VARCHAR(50), 
    p_salesytd NUMERIC, 
    p_saleslastyear NUMERIC, 
    p_costytd NUMERIC, 
    p_costlastyear NUMERIC
);

CREATE OR REPLACE FUNCTION sales.fn_salesterritory_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO sales.tb_salesterritory_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO sales.tb_salesterritory_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO sales.tb_salesterritory_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_salesterritory_auditoria
AFTER INSERT OR UPDATE OR DELETE ON sales.tb_salesterritory_auditoria
FOR EACH ROW EXECUTE PROCEDURE sales.fn_salesterritory_auditoria();

-- specialoffer
CREATE TABLE sales.tb_specialoffer_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_description VARCHAR(255), 
    p_discountpct NUMERIC, 
    p_type VARCHAR(50), 
    p_category VARCHAR(50), 
    p_startdate TIMESTAMP, 
    p_enddate TIMESTAMP, 
    p_minqty INTEGER, 
    p_maxqty INTEGER
);

CREATE OR REPLACE FUNCTION sales.fn_specialoffer_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO sales.tb_specialoffer_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO sales.tb_specialoffer_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO sales.tb_specialoffer_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_specialoffer_auditoria
AFTER INSERT OR UPDATE OR DELETE ON sales.tb_specialoffer_auditoria
FOR EACH ROW EXECUTE PROCEDURE sales.fn_specialoffer_auditoria();

-- specialofferproduct
CREATE TABLE sales.tb_specialofferproduct_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_specialofferid INTEGER, 
    p_productid INTEGER
);

CREATE OR REPLACE FUNCTION sales.fn_specialofferproduct_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO sales.tb_specialofferproduct_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO sales.tb_specialofferproduct_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO sales.tb_specialofferproduct_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_specialofferproduct_auditoria
AFTER INSERT OR UPDATE OR DELETE ON sales.tb_specialofferproduct_auditoria
FOR EACH ROW EXECUTE PROCEDURE sales.fn_specialofferproduct_auditoria();

-- store
CREATE TABLE sales.tb_store_auditoria (
    operacao CHAR NOT NULL,
    usuario VARCHAR NOT NULL,
    dt_hr TIMESTAMP NOT NULL,
    p_businessentityid INTEGER, 
    p_name VARCHAR(50), 
    p_salespersonid INTEGER, 
    p_demographics XML
);

CREATE OR REPLACE FUNCTION sales.fn_store_auditoria()
RETURNS trigger AS
$$
BEGIN
    IF (TG_OP = 'DELETE') THEN
        INSERT INTO sales.tb_store_auditoria
        SELECT 'E', user, NOW(), OLD.*;
        RETURN OLD;
    ELSIF (TG_OP = 'UPDATE') THEN
        INSERT INTO sales.tb_store_auditoria
        SELECT 'A', user, NOW(), NEW.*;
        RETURN NEW;
    ELSIF (TG_OP = 'INSERT') THEN
        INSERT INTO sales.tb_store_auditoria
        SELECT 'I', user, NOW(), NEW.*;
        RETURN NEW;
    END IF;
    RETURN NULL;
END
$$
LANGUAGE plpgsql;

CREATE TRIGGER tg_store_auditoria
AFTER INSERT OR UPDATE OR DELETE ON sales.tb_store_auditoria
FOR EACH ROW EXECUTE PROCEDURE sales.fn_store_auditoria();
