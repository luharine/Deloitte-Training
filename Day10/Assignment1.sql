CREATE DATABASE ShoppingCartDb;


 CREATE TABLE USERS (
    UserId INT,
    UserName VARCHAR(20),
    Password VARCHAR(20),
    ContactNumber VARCHAR(10),
    City VARCHAR(20),
    CONSTRAINT CHK_USERS_ContactNumber CHECK ((LEN(ContactNumber)= 10) and  ContactNumber NOT LIKE '%[^0-9]%')
);


CREATE TABLE PRODUCTS(	
			ProductId INT Primary Key,
			ProductName VARCHAR(20) Not Null, 
			QuantityInStock INT Not Null,
			UnitPrice  INT Not Null,
		    Category  VARCHAR(20)   Not null,
			CONSTRAINT CHK_PRODUCTS_QuantityInStock CHECK (QuantityInStock>0),
			CONSTRAINT CHK_PRODUCTS_UnitPrice CHECK (UnitPrice>0)


);

CREATE TABLE CART(
                Id INT Primary Key,  
				CartId VARCHAR(20) NOT NULL, 
			    ProductId  INT, 
				Quantity INT Not Null,
				CONSTRAINT CHK_CART_Quantity CHECK(Quantity>0),
				CONSTRAINT FK_CART_Q FOREIGN KEY(ProductId)
	            REFERENCES PRODUCTS(ProductId)

);				




a.Display all Products
b.Display Products belongs to particular category
c.Display out of stock products (means quantity is zero)
d.Display the products which price between 1000 to 10000 
e.Display the product details based on the ProductId    

select * from PRODUCTS;
select * from Products where Category = 'Electronics';
select * from Products where QuantityInStock =0;
select * from Products where (UnitPrice >70 and UnitPrice < 300);
select * from products where ProductId=7;




ii.   On Cart Table:
		a.  Display data based on the given CartId
		b.  Check is there any products added in Cart based on the ProductId

select * from cart;
select * from cart where cartid='CART001';
select ProductName from Products where ProductId in (select ProductId from cart);



iii.   On Users Table
			a. Display All users 
			b. Display user details based on ContactNumber
			c. Display user details based on UserId

select * from Users;
select * from Users where ContactNumber='1234567890';
select * from Users where UserId=1;


