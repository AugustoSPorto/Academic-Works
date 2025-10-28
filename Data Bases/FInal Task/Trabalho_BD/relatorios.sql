-- Relatório de Inventário de Produtos 

CREATE VIEW product_inventory AS
SELECT
    pi.productid,
    p.name AS product_name,
    pi.quantity,
    pi.locationid
FROM
    production.productinventory pi
JOIN
    production.product p ON pi.productid = p.productid
ORDER BY
    pi.quantity DESC;
	
--SELECT * FROM product_inventory;


--Relatório de Salários e Histórico de Pagamentos

CREATE VIEW employee_salary_history AS
SELECT
    e.businessentityid, 
    p.firstname || ' ' || p.lastname AS fullname,
    eph.rate,
    eph.ratechangedate
FROM
    humanresources.employeepayhistory eph
JOIN
    humanresources.employee e ON eph.businessentityid = e.businessentityid
JOIN
    person.person p ON e.businessentityid = p.businessentityid
ORDER BY
    eph.ratechangedate DESC;

	
--SELECT * FROM employee_salary_history;

--Relatório de Vendas por Território
CREATE VIEW sales_by_territory AS
SELECT
    st.territoryid,
    st.name AS territory_name,
    SUM(sod.orderqty * sod.unitprice) AS total_sales
FROM
    sales.salesorderheader soh
JOIN
    sales.salesterritory st ON soh.territoryid = st.territoryid
JOIN
    sales.salesorderdetail sod ON soh.salesorderid = sod.salesorderid
GROUP BY
    st.territoryid,
    st.name
ORDER BY
    total_sales DESC;

--SELECT * FROM sales_by_territory;