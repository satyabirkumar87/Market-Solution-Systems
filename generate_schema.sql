CREATE TABLE cash_sale (
	ID			INTEGER	PRIMARY KEY AUTOINCREMENT,
	ProdName	TEXT	NOT NULL,
	ProdQty		INTEGER	NOT NULL,
	SaleDate	TEXT	DEFAULT(datetime()),
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
	ID			TEXT(8)		NOT NULL,
	Username	TEXT	PRIMARY KEY,
	Password	TEXT	NOT NULL,
	Gender		TEXT		NOT NULL,
	PhoneNo		TEXT(10)	Not NULL,
	Address		TEXT		NOT NULL
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


CREATE TABLE Feedback (
	FDID		INTEGER	PRIMARY KEY AUTOINCREMENT,	
	CustID		TEXT	REFERENCES customer(ID),
	ProdName	TEXT	REFERENCES product(Name),
	Rating		INTEGER NOT NULL,
	Feedback	Text	NOT NULL
);