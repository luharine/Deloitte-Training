
--1   Creates a view that selects every product in the "Products" table with a price less than the average price

   CREATE VIEW LowCostProductsView AS
   SELECT ProductName,UnitPrice FROM Products 
   WHERE UnitPrice < (SELECT AVG(UnitPrice) from PRODUCTS); 

--2     Display the results by using the View

SELECT * FROM LowCostProductsView;


--3    Rename the View as   "Low Cost Products"	

EXEC sp_rename 'LowCostProductsView','Low Cost Products'

select * from NewLowCostProductsView;


-----4   Drop the view

DROP VIEW NewLowCostProductsView;








	
--1 Read required data from the Products table

CREATE PROCEDURE  uspGetProducts
AS
BEGIN
	SELECT * FROM Products;

END;

EXEC uspGetProducts

--2&3  Find the total amount of each product :  Consider UnitsOnOrder, UnitPrice,  --3   You need to display product name and total amount in the output	

ALTER PROCEDURE GetTotalAmount
AS
BEGIN
     SELECT ProductName, UnitsOnOrder*UnitPrice as Total_Amount from Products;
END;

EXEC GetTotalAmount

--4      Also display grand total at the end. 


ALTER PROCEDURE  GetGrandTotal
AS

OPEN cursor_product;          

DECLARE @ProductName VARCHAR(MAX),  @Total_Amount   DECIMAL, @GrandTotal DECIMAL;  
SET @GRANDTOTAL = 0.00;
FETCH NEXT FROM cursor_product INTO  @ProductName, @Total_Amount;
PRINT @ProductName
PRINT @Total_Amount


    WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT @ProductName + ' - ' +  CAST(@Total_Amount AS varchar);
        FETCH NEXT FROM cursor_product INTO  @ProductName,  @Total_Amount;
		SET @GrandTotal+=@Total_Amount;
     END;
	 PRINT('GRAND '+ CAST (@GrandTotal AS VARCHAR));

CLOSE cursor_product;

EXEC  GetGrandTotal


--5 Display the total amounts with only two decimal points:


ALTER PROCEDURE  GetGrandTotalWith2DecimalPlaces
AS

OPEN cursor_product;          

DECLARE @ProductName VARCHAR(MAX),  @Total_Amount   DECIMAL, @GrandTotal DECIMAL(10,2);  
SET @GRANDTOTAL = 0.00;
FETCH NEXT FROM cursor_product INTO  @ProductName, @Total_Amount;
PRINT @ProductName
PRINT @Total_Amount


    WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT @ProductName + ' - ' +  CAST(@Total_Amount AS varchar);
        FETCH NEXT FROM cursor_product INTO  @ProductName,  @Total_Amount;
		SET @GrandTotal+=@Total_Amount;
     END;
	 PRINT('GRAND '+ CAST (@GrandTotal AS VARCHAR));

CLOSE cursor_product;

EXEC  GetGrandTotalWith2DecimalPlaces




	 