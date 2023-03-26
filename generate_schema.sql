CREATE TABLE cash_sale (
	ID			TEXT(8)	PRIMARY KEY,
	ProductID	INTEGER NOT NULL,
	SaleDate	TEXT	NOT NULL,
	Discount	INTEGER NOT NULL
);



CREATE TABLE product (
	Name		TEXT	PRIMARY KEY,
	CompanyName	TEXT	REFERENCES	Company(Name),
	Price		INTEGER	NOT NULL,
	ProdQty		INTEGER	NOT NULL
);



-- CREATE TABLE stock (
-- 	ProductId	TEXT(8) REFERENCES Product(ID),
-- 	CompanyId	INTEGER	REFERENCES Company(ID),
-- 	Quantity	INTEGER NOT NULL,
-- 	ProductName	TEXT NOT NULL
-- );


CREATE TABLE customer (
	ID		TEXT(8)	NOT NULL,
	Username	TEXT		PRIMARY KEY,
	Password	TEXT		NOT NULL,
	Gender	TEXT		NOT NULL,
	PhoneNo	TEXT(10)	Not NULL,
	Address	TEXT		NOT NULL
);



-- CREATE TABLE employee (
-- 	ID TEXT(8) PRIMARY KEY,
-- 	Name	TEXT	NOT NULL,
-- 	PhoneNo	TEXT	NOT NULL,
-- 	Address	TEXT	NOT NULL,
-- 	Salary	TEXT	NOT NULL
-- );


create table company (
	Name	TEXT	PRIMARY KEY,
	Address	TEXT	NOT NULL,
	PhoneNo	TEXT	NOT NULL
);