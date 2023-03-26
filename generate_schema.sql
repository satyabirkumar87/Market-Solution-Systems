CREATE TABLE cash_sale (
	ID			INTEGER PRIMARY KEY,
	ProductID	INTEGER NOT NULL,
	SaleDate	Text,
	Discount	INTEGER NOT NULL,
);



CREATE TABLE Product (
	ID 		INTEGER PRIMARY KEY,
	Name	Text	NOT NULL,
	CompanyID	INTEGER REFERENCES Company(ID),
	Price		Text	NOT NULL,
	ExpiryDate	Text	NOT NULL
);



CREATE TABLE stock (
	ID	INTEGER Re
);