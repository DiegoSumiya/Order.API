CREATE TABLE USERS
(
	ID VARCHAR(32) NOT NULL PRIMARY KEY,
	NAME VARCHAR(100) NOT NULL,
	LOGIN VARCHAR(20) NOT NULL,
	PASSWORDHASH VARCHAR(MAX) NOT NULL,
	CREATED DATE
)

CREATE TABLE PRODUCT
(
	ID VARCHAR(32) NOT NULL PRIMARY KEY,
	DESCRIPTION VARCHAR(100) NOT NULL,
	SELLVALUE NUMERIC(8,2) NOT NULL,
	STOCK INTEGER NOT NULL,
	CREATED DATE
)

CREATE TABLE CLIENT
(
	ID VARCHAR(32) NOT NULL PRIMARY KEY,
	NAME VARCHAR(100) NOT NULL,
	EMAIL VARCHAR(100) NOT NULL,
	PHONENUMBER VARCHAR(14) NOT NULL,
	ADRESS VARCHAR(200) NOT NULL,
	CREATED DATETIME
)


CREATE TABLE ORDERITEM
(
	ID VARCHAR(32) NOT NULL PRIMARY KEY,
	ORDERID VARCHAR(32) NOT NULL,
	PRODUCTID VARCHAR(32) NOT NULL,
	SELLVALUE NUMERIC(8,2) NOT NULL,
	QUANTITY INTEGER NOT NULL,
	TOTALAMOUNT NUMERIC (8,2) NOT NULL,
	CREATED DATETIME
)

CREATE TABLE ORDERS
(
	ID VARCHAR (32) NOT NULL PRIMARY KEY,
	CLIENTID VARCHAR (32) NOT NULL,
	USERID VARCHAR (32) NOT NULL,
	CREATED DATETIME
)

ALTER TABLE ORDERS ADD FOREIGN KEY (USERID)
REFERENCES USERS (ID)

ALTER TABLE ORDERS ADD FOREIGN KEY (CLIENTID)
REFERENCES CLIENT (ID)

ALTER TABLE ORDERITEM ADD FOREIGN KEY (ORDERID)
REFERENCES ORDERS (ID)

ALTER TABLE ORDERITEM ADD FOREIGN KEY (PRODUCTID)
REFERENCES PRODUCT (ID)