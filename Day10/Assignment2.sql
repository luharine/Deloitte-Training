2.1. Write the sql queries for the following requirements  by using joins concept:

	a. Consider the Products table and Cart table 
	b. Write a Query to display the results from the above two tables:
			CartId,  ProductName, Quantity, UnitPrice
			
		Hint :  Quantity should takes from Cart table
			
	c.  Try to appy inner join,  right outer join , left outer join and full outer join on the above tables.

SELECT C.CartId,  P.ProductName, C.Quantity, P.UnitPrice
FROM CART C INNER JOIN PRODUCTS P
ON c.Id = p.ProductId;

SELECT C.CartId,  P.ProductName, C.Quantity, P.UnitPrice
FROM CART C RIGHT OUTER JOIN PRODUCTS P
ON c.Id = p.ProductId;

SELECT C.CartId,  P.ProductName, C.Quantity, P.UnitPrice
FROM CART C LEFT OUTER JOIN PRODUCTS P
ON c.Id = p.ProductId;

SELECT C.CartId, C.Quantity, P.UnitPrice,P.ProductName
FROM CART C FULL OUTER JOIN PRODUCTS P
ON C.Id = p.ProductId;



CREATE TABLE Student (
    StudentId INT PRIMARY KEY,
    StudentName VARCHAR(50) NOT NULL,
    CourseName VARCHAR(50) NOT NULL,
    CityName VARCHAR(50) NOT NULL
);
ALTER TABLE Student
ADD ContactNumber VARCHAR(15);


SELECT * FROM STUDENT;

INSERT INTO Student (StudentId, StudentName, CourseName, CityName, ContactNumber) VALUES
(1, 'Rahul Sharma', 'Angular', 'Hyderabad', '9876543210'),
(2, 'Priya Singh', 'React', 'Mumbai', '8765432109'),
(3, 'Amit Patel', '.NET', 'Pune', '7654321098'),
(4, 'Sneha Desai', 'Angular', 'Ahmedabad', '6543210987'),
(5, 'Rohit Verma', 'React', 'Hyderabad', '5432109876'),
(6, 'Anjali Mehta', '.NET', 'Mumbai', '4321098765'),
(7, 'Vikas Gupta', 'Angular', 'Pune', '3210987654'),
(8, 'Kavita Rao', 'React', 'Ahmedabad', '2109876543'),
(9, 'Suresh Kumar', '.NET', 'Hyderabad', '1098765432'),
(10, 'Neha Joshi', 'Angular', 'Mumbai', '0987654321'),
(11, 'Manish Singh', 'React', 'Pune', '9876543211'),
(12, 'Pooja Sharma', '.NET', 'Ahmedabad', '8765432108'),
(13, 'Rajesh Kumar', 'Angular', 'Hyderabad', '7654321097'),
(14, 'Meera Desai', 'React', 'Mumbai', '6543210986'),
(15, 'Vijay Patel', '.NET', 'Pune', '5432109875'),
(16, 'Shweta Verma', 'Angular', 'Ahmedabad', '4321098764'),
(17, 'Arjun Mehta', 'React', 'Hyderabad', '3210987653'),
(18, 'Ritu Gupta', '.NET', 'Mumbai', '2109876542'),
(19, 'Nikhil Rao', 'Angular', 'Pune', '1098765431'),
(20, 'Divya Joshi', 'React', 'Ahmedabad', '0987654320');

a.   Find out how many Students are joined for "Angular"  Course

SELECT * FROM Student WHERE CourseName = 'Angular';

b.   Find out how many Students are joined from  "Hyderabad"  City

SELECT * FROM STUDENT WHERE CityName = 'Hyderabad';

c.    Display No. of Students are join from each  City based 
	
			Sample Output:
						Hyderabad    10
						Mumbai   20
						Pune   5
						.....

SELECT CityName, Count(StudentName) as NumberOfStudents FROM STUDENT GROUP BY CityName; 



	
	d.    Display No. of Students are join from each  Course  based 
			Sample Outupt:
					Angular    10
					React       20
					.NET        30
					....... 

SELECT  CourseName, Count(StudentName) as NumberOfStudents FROM STUDENT GROUP BY CourseName; 
					
	e.     Display the counts  by grouping based on  city, course 


SELECT  CourseName,CityName,Count(StudentName) as NumberOfStudents FROM STUDENT GROUP BY CityName,CourseName; 
	


2.3.  Prepare the sql queries for the following requirements (use subqueries):
			
			a.   Display the products if any items exists in the cart table
			b.   Display the cart items whoe product price greater than 5000 
			
select ProductId, ProductName from Products where productId in (select productId from cart);

select ProductId, CartId, Quantity from Cart where productId in (select productId from products where UnitPrice > 500);






