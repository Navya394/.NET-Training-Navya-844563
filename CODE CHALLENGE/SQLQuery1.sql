CREATE TABLE PRODUCTS
(
PRODUCTID INT NOT NULL,
PRODUCTNAME VARCHAR(20),
SUPPLIERID INT,
CATEGORYID INT,
QUANTITYPERUNIT VARCHAR(20),
UNITPRICE DECIMAL(10,4),
UNITSINSTOCK SMALLINT,
UNITSONORDER SMALLINT,
REORDERLEVEL SMALLINT,
DISCONTINUED BIT,
PRIMARY KEY(PRODUCTID)
)

SELECT PRODUCTID,PRODUCTNAME FROM PRODUCTS WHERE DISCONTINUED=1 ORDER BY PRODUCTNAME





