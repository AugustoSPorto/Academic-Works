--		HUMANRESOURCES
--employee
CREATE OR REPLACE FUNCTION humanresources.insert_employee(
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
    p_orgnode VARCHAR
)
RETURNS VOID AS 
$$
BEGIN
    INSERT INTO humanresources.employee VALUES (
        p_businessentityid, 
        p_nationalidnumber, 
        p_loginid, 
        p_jobtitle, 
        p_birthdate, 
        p_maritalstatus, 
        p_gender, 
        p_hiredate, 
        p_salariedflag, 
        p_vacationhours, 
        p_sickleavehours, 
        p_currentflag, 
        LOCALTIMESTAMP, 
        p_orgnode
    );
END;
$$ 
LANGUAGE PLPGSQL;



--		PERSON
-- address
CREATE OR REPLACE FUNCTION person.insert_address(
    p_addressline1 VARCHAR(60), 
    p_addressline2 VARCHAR(60), 
    p_city VARCHAR(30), 
    p_stateprovinceid INTEGER, 
    p_postalcode VARCHAR(15), 
    p_spatiallocation BYTEA
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('person.address_addressid_seq', (SELECT MAX(addressid) FROM person.address));
    INSERT INTO person.address VALUES (
		NEXTVAL('person.address_addressid_seq'),
        p_addressline1, 
        p_addressline2, 
        p_city, 
        p_stateprovinceid, 
        p_postalcode, 
        p_spatiallocation, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--businessentity
CREATE OR REPLACE FUNCTION person.insert_businessentity()
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('person.businessentity_businessentityid_seq', (SELECT MAX(businessentityid) FROM person.businessentity));
    INSERT INTO person.businessentity VALUES (
        NEXTVAL('person.businessentity_businessentityid_seq'), 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

-- countryregion
CREATE OR REPLACE FUNCTION person.insert_countryregion(
    p_countryregioncode VARCHAR(3), 
    p_name VARCHAR(50)
)
RETURNS VOID AS 
$$
BEGIN
    INSERT INTO person.countryregion VALUES (
        p_countryregioncode, 
        p_name, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--email_address
CREATE OR REPLACE FUNCTION person.insert_emailaddress(
    p_businessentityid INTEGER, 
    p_emailaddress VARCHAR(50)
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('person.emailaddress_emailaddressid_seq', (SELECT MAX(emailaddressid) FROM person.emailaddress));
    INSERT INTO person.emailaddress VALUES (
        p_businessentityid, 
		NEXTVAL('person.emailaddress_emailaddressid_seq'),
        p_emailaddress, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--password
CREATE OR REPLACE FUNCTION person.insert_password(
    p_businessentityid INTEGER, 
    p_passwordhash VARCHAR(128), 
    p_passwordsalt VARCHAR(10)
)
RETURNS VOID AS 
$$
BEGIN
    INSERT INTO person.password VALUES(
        p_businessentityid, 
        p_passwordhash, 
        p_passwordsalt, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--person
CREATE OR REPLACE FUNCTION person.insert_person(
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
    p_demographics XML
)
RETURNS VOID AS 
$$
BEGIN
    INSERT INTO person.person 
    VALUES (
        p_businessentityid, 
        p_persontype, 
        p_namestyle, 
        p_title, 
        p_firstname, 
        p_middlename, 
        p_lastname, 
        p_suffix, 
        p_emailpromotion, 
        p_additionalcontactinfo, 
        p_demographics, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--personphone
CREATE OR REPLACE FUNCTION person.insert_personphone(
    p_businessentityid INTEGER, 
    p_phonenumber VARCHAR(25), 
    p_phonenumbertypeid INTEGER
)
RETURNS VOID AS 
$$
BEGIN
    INSERT INTO person.personphone VALUES (
        p_businessentityid, 
        p_phonenumber, 
        p_phonenumbertypeid, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--phonenumbertype
CREATE OR REPLACE FUNCTION person.insert_phonenumbertype(
    p_name VARCHAR(50)
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('person.phonenumbertype_phonenumbertypeid_seq', (SELECT MAX(phonenumbertypeid) FROM person.phonenumbertype));
    INSERT INTO person.phonenumbertype VALUES (
        NEXTVAL('person.phonenumbertype_phonenumbertypeid_seq'), 
        p_name, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--stateprovince
CREATE OR REPLACE FUNCTION person.insert_stateprovince(
    p_stateprovincecode CHARACTER, 
    p_countryregioncode VARCHAR(3), 
    p_isonlystateprovinceflag BOOLEAN, 
    p_name VARCHAR(50), 
    p_territoryid INTEGER
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('person.stateprovince_stateprovinceid_seq', (SELECT MAX(stateprovinceid) FROM person.stateprovince));
    INSERT INTO person.stateprovince VALUES (
		NEXTVAL('person.stateprovince_stateprovinceid_seq'),
        p_stateprovincecode, 
        p_countryregioncode, 
        p_isonlystateprovinceflag, 
        p_name, 
        p_territoryid, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;


--		PRODUCTION
--product
CREATE OR REPLACE FUNCTION production.insert_product(
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
    p_discontinueddate TIMESTAMP
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('production.product_productid_seq', (SELECT MAX(productid) FROM production.product));
    INSERT INTO production.product VALUES (
		NEXTVAL('production.product_productid_seq'),
        p_name, 
        p_productnumber, 
        p_makeflag, 
        p_finishedgoodsflag, 
        p_color, 
        p_safetystocklevel, 
        p_reorderpoint, 
        p_standardcost, 
        p_listprice, 
        p_size, 
        p_sizeunitmeasurecode, 
        p_weightunitmeasurecode, 
        p_weight, 
        p_daystomanufacture, 
        p_productline, 
        p_class, 
        p_style, 
        p_productsubcategoryid, 
        p_productmodelid, 
        p_sellstartdate, 
        p_sellenddate, 
        p_discontinueddate, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--productcategory
CREATE OR REPLACE FUNCTION production.insert_productcategory(
    p_name VARCHAR(50)
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('production.productcategory_productcategoryid_seq', (SELECT MAX(productcategoryid) FROM production.productcategory));
    INSERT INTO production.productcategory VALUES (
		NEXTVAL('production.productcategory_productcategoryid_seq'),
        p_name, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--productmodel
CREATE OR REPLACE FUNCTION production.insert_productmodel(
    p_name VARCHAR(50), 
    p_catalogdescription XML, 
    p_instructions XML
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('production.productmodel_productmodelid_seq', (SELECT MAX(productmodelid) FROM production.productmodel));
    INSERT INTO production.productmodel VALUES (
        NEXTVAL('production.productmodel_productmodelid_seq'), 
        p_name, 
        p_catalogdescription, 
        p_instructions, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

-- productsubcategory
CREATE OR REPLACE FUNCTION production.insert_productsubcategory(
    p_productcategoryid INTEGER, 
    p_name VARCHAR(50)
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('production.productsubcategory_productsubcategoryid_seq', (SELECT MAX(productsubcategoryid) FROM production.productsubcategory));
    INSERT INTO production.productsubcategory VALUES (
		NEXTVAL('production.productsubcategory_productsubcategoryid_seq'),
        p_productcategoryid, 
        p_name, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--transactionhistory
CREATE OR REPLACE FUNCTION production.insert_transactionhistory(
    p_productid INTEGER, 
    p_referenceorderid INTEGER, 
    p_referenceorderlineid INTEGER, 
    p_transactiondate TIMESTAMP, 
    p_transactiontype CHARACTER, 
    p_quantity INTEGER, 
    p_actualcost NUMERIC
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('production.transactionhistory_transactionid_seq', (SELECT MAX(transactionid) FROM production.transactionhistory));
    INSERT INTO production.transactionhistory VALUES (
        NEXTVAL('production.transactionhistory_transactionid_seq'), 
        p_productid, 
        p_referenceorderid, 
        p_referenceorderlineid, 
        p_transactiondate, 
        p_transactiontype, 
        p_quantity, 
        p_actualcost, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--unitmeasure
CREATE OR REPLACE FUNCTION production.insert_unitmeasure(
    p_unitmeasurecode CHARACTER, 
    p_name VARCHAR(50)
)
RETURNS VOID AS 
$$
BEGIN
    INSERT INTO production.unitmeasure VALUES (
        p_unitmeasurecode, 
        p_name, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;
 

--		PURCHASING
--productvendor
CREATE OR REPLACE FUNCTION purchasing.insert_productvendor(
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
)
RETURNS VOID AS 
$$
BEGIN
    INSERT INTO purchasing.productvendor VALUES (
        p_productid, 
        p_businessentityid, 
        p_averageleadtime, 
        p_standardprice, 
        p_lastreceiptcost, 
        p_lastreceiptdate, 
        p_minorderqty, 
        p_maxorderqty, 
        p_onorderqty, 
        p_unitmeasurecode, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--purchaseorderdetail
CREATE OR REPLACE FUNCTION purchasing.insert_purchaseorderdetail(
    p_purchaseorderid INTEGER, 
    p_duedate TIMESTAMP, 
    p_orderqty INTEGER, 
    p_productid INTEGER, 
    p_unitprice NUMERIC, 
    p_receivedqty NUMERIC(8,2), 
    p_rejectedqty NUMERIC(8,2)
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('purchasing.purchaseorderdetail_purchaseorderdetailid_seq', (SELECT MAX(purchaseorderdetailid) FROM purchasing.purchaseorderdetail));
    INSERT INTO purchasing.purchaseorderdetail VALUES (
        p_purchaseorderid, 
		NEXTVAL('purchasing.purchaseorderdetail_purchaseorderdetailid_seq'),
        p_duedate, 
        p_orderqty, 
        p_productid, 
        p_unitprice, 
        p_receivedqty, 
        p_rejectedqty, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--purchaseorderheader
CREATE OR REPLACE FUNCTION purchasing.insert_purchaseorderheader(
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
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('purchasing.purchaseorderheader_purchaseorderid_seq', (SELECT MAX(purchaseorderid) FROM purchasing.purchaseorderheader));
    INSERT INTO purchasing.purchaseorderheader VALUES (
		NEXTVAL('purchasing.purchaseorderheader_purchaseorderid_seq'),
        p_revisionnumber, 
        p_status, 
        p_employeeid, 
        p_vendorid, 
        p_shipmethod, 
        p_orderdate, 
        p_shipdate, 
        p_subtotal, 
        p_taxamt, 
        p_freight, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--shipmethod
CREATE OR REPLACE FUNCTION purchasing.insert_shipmethod(
    p_name VARCHAR(50), 
    p_shipbase NUMERIC, 
    p_shiprate NUMERIC
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('purchasing.shipmethod_shipmethodid_seq', (SELECT MAX(shipmethodid) FROM purchasing.shipmethod));
    INSERT INTO purchasing.shipmethod VALUES (
		NEXTVAL('purchasing.shipmethod_shipmethodid_seq'),
        p_name, 
        p_shipbase, 
        p_shiprate, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--vendor
CREATE OR REPLACE FUNCTION purchasing.insert_vendor(
    p_businessentityid INTEGER, 
    p_accountnumber VARCHAR(15), 
    p_name VARCHAR(50), 
    p_creditrating INTEGER, 
    p_preferredvendorstatus BOOLEAN, 
    p_activeflag BOOLEAN, 
    p_purchasingwebserviceurl VARCHAR(1024)
)
RETURNS VOID AS 
$$
BEGIN
    INSERT INTO purchasing.vendor VALUES (
        p_businessentityid, 
        p_accountnumber, 
        p_name, 
        p_creditrating, 
        p_preferredvendorstatus, 
        p_activeflag, 
        p_purchasingwebserviceurl, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;


--		SALES
--creditcard
CREATE OR REPLACE FUNCTION sales.insert_creditcard(
    p_cardtype VARCHAR(50), 
    p_cardnumber VARCHAR(25), 
    p_expmonth INTEGER, 
    p_expyear INTEGER
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('sales.creditcard_creditcardid_seq', (SELECT MAX(creditcardid) FROM sales.creditcard));
    INSERT INTO sales.creditcard VALUES (
		NEXTVAL('sales.creditcard_creditcardid_seq'),
        p_cardtype, 
        p_cardnumber, 
        p_expmonth, 
        p_expyear, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--customer
CREATE OR REPLACE FUNCTION sales.insert_customer(
    p_personid INTEGER, 
    p_storeid INTEGER, 
    p_territoryid INTEGER
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('sales.customer_customerid_seq', (SELECT MAX(customerid) FROM sales.customer));
    INSERT INTO sales.customer VALUES (
		NEXTVAL('sales.customer_customerid_seq'),
        p_personid, 
        p_storeid, 
        p_territoryid, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--personcreditcard
CREATE OR REPLACE FUNCTION sales.insert_personcreditcard(
    p_businessentityid INTEGER, 
    p_creditcardid INTEGER
)
RETURNS VOID AS 
$$
BEGIN
    INSERT INTO sales.personcreditcard VALUES (
        p_businessentityid, 
        p_creditcardid, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

-- salesorderdetail
CREATE OR REPLACE FUNCTION sales.insert_salesorderdetail(
    p_salesorderid INTEGER, 
    p_carriertrackingnumber VARCHAR(25), 
    p_orderqty INTEGER, 
    p_productid INTEGER, 
    p_specialofferid INTEGER, 
    p_unitprice NUMERIC, 
    p_unitpricediscount NUMERIC
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('sales.salesorderdetail_salesorderdetailid_seq', (SELECT MAX(salesorderdetailid) FROM sales.salesorderdetail));
    INSERT INTO sales.salesorderdetail VALUES (
        p_salesorderid, 
		NEXTVAL('sales.salesorderdetail_salesorderdetailid_seq'),
        p_carriertrackingnumber, 
        p_orderqty, 
        p_productid, 
        p_specialofferid, 
        p_unitprice, 
        p_unitpricediscount, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--salesorderheader
CREATE OR REPLACE FUNCTION sales.insert_salesorderheader(
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
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('sales.salesorderheader_salesorderid_seq', (SELECT MAX(salesorderid) FROM sales.salesorderheader));
    INSERT INTO sales.salesorderheader VALUES (
		NEXTVAL('sales.salesorderheader_salesorderid_seq'),
    	p_revisionnumber, 
        p_orderdate, 
        p_duedate, 
        p_shipdate, 
        p_status, 
        p_onlineorderflag, 
        p_purchaseordernumber, 
        p_accountnumber, 
        p_customerid, 
        p_salespersonid, 
		p_territoryid, 
		p_billtoaddressid, 
    	p_shiptoaddressid, 
    	p_shipmethodid, 
   		p_creditcardid, 
    	p_creditcardapprovalcode, 
    	p_currencyrateid, 
   		p_subtotal, 
    	p_taxamt, 
   		p_freight, 
    	p_totaldue, 
 		p_commentary 
);
END;
$$ 
LANGUAGE PLPGSQL;

--salesperson
CREATE OR REPLACE FUNCTION sales.insert_salesperson(
    p_businessentityid INTEGER, 
    p_territoryid INTEGER, 
    p_salesquota NUMERIC, 
    p_bonus NUMERIC, 
    p_commissionpct NUMERIC, 
    p_salesytd NUMERIC, 
    p_saleslastyear NUMERIC
)
RETURNS VOID AS 
$$
BEGIN
    INSERT INTO sales.salesperson VALUES (
        p_businessentityid, 
        p_territoryid, 
        p_salesquota, 
        p_bonus, 
        p_commissionpct, 
        p_salesytd, 
        p_saleslastyear, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--salesterritory
CREATE OR REPLACE FUNCTION sales.insert_salesterritory(
    p_name VARCHAR(50), 
    p_countryregioncode VARCHAR(3), 
    p_grp VARCHAR(50), 
    p_salesytd NUMERIC, 
    p_saleslastyear NUMERIC, 
    p_costytd NUMERIC, 
    p_costlastyear NUMERIC
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('sales.salesterritory_territoryid_seq', (SELECT MAX(territoryid) FROM sales.salesterritory));
    INSERT INTO sales.salesterritory VALUES (
		NEXTVAL('sales.salesterritory_territoryid_seq'),
        p_name, 
        p_countryregioncode, 
        p_grp, 
        p_salesytd, 
        p_saleslastyear, 
        p_costytd, 
        p_costlastyear, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--specialoffer
CREATE OR REPLACE FUNCTION sales.insert_specialoffer(
    p_description VARCHAR(255), 
    p_discountpct NUMERIC, 
    p_type VARCHAR(50), 
    p_category VARCHAR(50), 
    p_startdate TIMESTAMP, 
    p_enddate TIMESTAMP, 
    p_minqty INTEGER, 
    p_maxqty INTEGER
)
RETURNS VOID AS 
$$
BEGIN
    PERFORM setval('sales.specialoffer_specialofferid_seq', (SELECT MAX(specialofferid) FROM sales.specialoffer));
    INSERT INTO sales.specialoffer VALUES (
        NEXTVAL('sales.specialoffer_specialofferid_seq'), 
        p_description, 
        p_discountpct, 
        p_type, 
        p_category, 
        p_startdate, 
        p_enddate, 
        p_minqty, 
        p_maxqty, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--specialofferproduct
CREATE OR REPLACE FUNCTION sales.insert_specialofferproduct(
    p_specialofferid INTEGER, 
    p_productid INTEGER
)
RETURNS VOID AS 
$$
BEGIN
    INSERT INTO sales.specialofferproduct VALUES (
        p_specialofferid, 
        p_productid, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

--store
CREATE OR REPLACE FUNCTION sales.insert_store(
    p_businessentityid INTEGER, 
    p_name VARCHAR(50), 
    p_salespersonid INTEGER, 
    p_demographics XML
)
RETURNS VOID AS 
$$
BEGIN
    INSERT INTO sales.store VALUES (
        p_businessentityid, 
        p_name, 
        p_salespersonid, 
        p_demographics, 
        DEFAULT, 
        LOCALTIMESTAMP
    );
END;
$$ 
LANGUAGE PLPGSQL;

