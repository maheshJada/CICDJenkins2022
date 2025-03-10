======================================================================================<InterViewQuestions>=====================================================
#Sql Qurestions

1. differnec between truncate and delete, drop

	TRUNCATE:
		
		TRUNCATE statement is used to quickly remove all the rows from a table.
		Usage: It removes all the data from the table, but the table structure, constraints, and indexes remain intact.
		TRUNCATE TABLE table_name;
		It can not be ROLLBACK , you can not undo operation
	
	DELETE:
	The DELETE statement is used to remove specific rows from a table based on certain conditions
	It can be ROLLBACK , you can undo operation.
	
2. joins

	In SQL, a JOIN is used to combine rows from two or more tables based on related columns between them
	Joins allow you to retrieve data from multiple tables simultaneously
	
		INNER JOIN:
		The INNER JOIN returns only the rows that have matching values in both tables.
		
			SELECT Customers.Name, Orders.OrderID, Orders.Product
			FROM Customers
			INNER JOIN Orders
			ON Customers.CustomerID = Orders.CustomerID;
			
		LEFT JOIN (or LEFT OUTER JOIN):
		The LEFT JOIN returns all the rows from the left table and the matched rows from the right table. 
		If there are no matching rows in the right table, the result will contain NULL  values from right table
		
				SELECT Customers.Name, Orders.OrderID, Orders.Product
				FROM Customers
				LEFT JOIN Orders
				ON Customers.CustomerID = Orders.CustomerID;

		
		RIGHT JOIN (or RIGHT OUTER JOIN):
		The RIGHT JOIN is the reverse of the LEFT JOIN. It returns all the rows from the right table and the matched rows from the left table
	
				SELECT Customers.Name, Orders.OrderID, Orders.Product
				FROM Customers
				RIGHT JOIN Orders
				ON Customers.CustomerID = Orders.CustomerID;
				
		FULL JOIN (or FULL OUTER JOIN):
		The FULL JOIN returns all the rows when there is a match in either the left or the right table. 
		If there is no match in one of the tables, the result will contain null VALUE in respecive colums
		
				SELECT Customers.Name, Orders.OrderID, Orders.Product
				FROM Customers
				FULL JOIN Orders
				ON Customers.CustomerID = Orders.CustomerID;

		CROSS JOIN:

		The CROSS JOIN produces a Cartesian product of the two tables,
		meaning it combines every row from the first table with every row from the second table.
				SELECT Colors.Color, Sizes.Size
				FROM Colors
				CROSS JOIN Sizes;
		

		Self JOIN:
		
		A self-join  table is joined with itself
		To perform a self-join, you need to use table aliases to distinguish between the different instances of the same table within the query.
		This allows you to treat the table as if it were two separate entities.		
		
		Employees Table:

			EmployeeID	Name	ManagerID
			1			John	3
			2			Alice	3
			3			Michael	4
			4			Sarah	NULL
			5			David	4
			
			SELECT e1.Name AS EmployeeName, e2.Name AS ManagerName
			FROM Employees e1
			LEFT JOIN Employees e2
			ON e1.ManagerID = e2.EmployeeID;


----
In SQL, UNION and UNION ALL are used to combine the results of two or more SELECT queries into a single result set


UNION:

The UNION operator combines the results of multiple SELECT queries and removes any duplicate rows from the final result set

		SELECT ID FROM SectionA
		UNION
		SELECT ID FROM SectionB;

UNION ALL:

The UNION ALL operator also combines the results of multiple SELECT queries, but it retains all rows, including duplicates

		SELECT Name FROM Employees
		UNION ALL
		SELECT Name FROM Employees;
-----

3. what are differnt types of aggregrate functiosn


			Employees Table:

			EmployeeID		Name	Department	Salary
			1				John	HR		50000
			2				Alice	IT		60000
			3				Michael	HR		55000
			4				Sarah	Finance	65000
			5				David	IT		52000
			
			
SELECT COUNT(EmployeeID) AS TotalEmployees FROM Employees;   5
SELECT SUM(Salary) AS TotalSalary FROM Employees;   TotalSalary = 282000
SELECT FIRST(Name) AS FirstEmployee FROM Employees;   John


SELECT Department, GROUP_CONCAT(Name) AS EmployeesList FROM Employees GROUP BY Department;

			Result:

			Department	EmployeesList
			HR			John, Michael
			IT			Alice, David
			Finance		Sarah

		SELECT Product, COUNT(OrderID) AS NumberOfOrders
		FROM Orders
		GROUP BY Product;

		The result will be:

		Product	NumberOfOrders
		Apple	2
		Banana	2
		Orange	1
=====================================================================================Sql Aggregeate Functions===========================
Sample Data:

		Employee Table:

		EmpId	EmpName	Salary	Age	DeptID
			1	John	50000	30	1
			2	Alice	60000	28	2
			3	Michael	55000	35	1
			4	Sarah	65000	32	3
			5	David	52000	29	2
			
			
			Department Table:

			DeptId	DeptName
				1	HR
				2	IT
				3	Finance


SELECT COUNT(*) AS TotalEmployees FROM Employee;   TotalEmployees = 5
SELECT SUM(Salary) AS TotalSalary FROM Employee;   TotalSalary = 282000
SELECT AVG(Salary) AS AverageSalary FROM Employee;  AverageSalary = 56400
SELECT MIN(Salary) AS MinSalary FROM Employee;		 MinSalary = 50000
SELECT MAX(Salary) AS MaxSalary FROM Employee;      MaxSalary = 65000
SELECT DeptId, GROUP_CONCAT(EmpName) AS EmployeesList FROM Employee GROUP BY DeptId;  

			DeptId	EmployeesList
				1	John,Michael
				2	Alice,David
				3	Sarah
				
SELECT EmpId, EmpName, Salary FROM Employee;
UPDATE Employee SET Salary = Salary + 1000 WHERE Age > 30;
DELETE FROM Employee WHERE DeptID = 2;

INSERT INTO Employee (EmpName, Salary, Age, DeptID) VALUES ('Emily', 48000, 27, 1);
				
SELECT e.EmpName, d.DeptName
FROM Employee e
INNER JOIN Department d ON e.DeptID = d.DeptID;

--
Grouping and Aggregating Data:


SELECT d.DeptName, AVG(e.Salary) AS AvgSalary
FROM Employee e
INNER JOIN Department d ON e.DeptID = d.DeptID
GROUP BY d.DeptName

--
Subqueries:

Find employees with a salary greater than the average salary of all employees:

-
Calculate the average salary of employees within each department:				

		SELECT d.DeptName, COUNT(e.EmpId) AS EmployeeCount
		FROM Department d
		LEFT JOIN Employee e ON d.DeptId = e.DeptID
		GROUP BY d.DeptName;

		DeptName	EmployeeCount
			HR			2
			IT			2
			Finance		0
			Sales		3
------
find second highest salary

		SELECT Salary
		FROM Employee
		ORDER BY Salary DESC
		LIMIT 1 OFFSET 1;


 The LIMIT 1 part ensures that we only retrieve one row from the sorted result, 
 and the OFFSET 1 part skips the first row, effectively giving us the second-highest salary.
 
 
 or
 
		SELECT TOP 1 Salary
		FROM Employee
		ORDER BY Salary DESC
		OFFSET 1 ROWS;
	--	
	    SELECT TOP 3 Name, Salary
		FROM Employee
		ORDER BY Salary DESC;



			
4. differrence between stored procedure and function

Stored Procedure and Function are both database objects in SQL used for encapsulating a set of SQL statements to perform specific tasks

		Stored Procedure:

		A stored procedure is a set of SQL statements stored in the database.
		 It can include input parameters, output parameters, and be used to execute a series of SQL operations. 
		 
		 They can have both input and output parameters.
		They can execute DML (Data Manipulation Language) and DDL (Data Definition Language) statements.
		They are executed using the EXEC or CALL statement.
		
		Function:
		
		A function is a database object that takes input parameters, performs a calculation, and returns a single value. 
		Functions are generally used to perform calculations and return a specific value based on the input parameters.

			They cannot have output parameters.
			They only execute DQL (Data Query Language) statements.
			They are used in expressions or in SELECT statements to calculate and return values.
			
			
			
			stored procedures are used to encapsulate a series of SQL statements to perform complex tasks and can execute DML and DDL operations
			Functions:
			used for calculations and return a single scalar value based on input parameters, and they can only execute DQL operations. \
			
			stored procedures are used for performing complex tasks involving DML, DDL, and other operations, and they may or may not return values. 
			Functions, on the other hand, are designed for computations and always return a single scalar value
			
			
			
			Return Values:
			Error Handling  , Stored procedure will work in try catch block but not in Functions
			
			
			
									Basic function:
									
									
									Employee Table:

						EmpId	EmpName	Salary	Age	DeptID
						1	John	50000	30	1
						2	Alice	60000	28	2
						3	Michael	55000	35	1
						4	Sarah	65000	32	3
						5	David	52000	29	2
			
			
			
						CREATE FUNCTION GetTotalSalaryByDepartment(@deptID INT)
						RETURNS DECIMAL(10, 2)
						AS
						BEGIN
							DECLARE @totalSalary DECIMAL(10, 2);
							
							SELECT @totalSalary = SUM(Salary)
							FROM Employee
							WHERE DeptID = @deptID;

							RETURN @totalSalary;
						END;

			
5.Count the no of employes from each department

SELECT d.DeptName, COUNT(e.EmpId) AS EmployeeCount
		FROM Department d
		LEFT JOIN Employee e ON d.DeptId = e.DeptID
		GROUP BY d.DeptName;
		
		
5. tempary table, cte , and its differnece

		Temparary Table:It exists temporarily within a database session
		They are accessible only to the session that created them and are automatically dropped when the session ends or is closed
		Temporary tables  store and manipulate data for a short period within the scope of a session or a TRANSACTION
		
		Session-Scoped Temporary Tablle:
			Session-scoped temporary tables are created and exist for the duration of the session
			CREATE TEMPORARY TABLE
			
		Transaction-Scoped Temporary Table	
			Transaction-scoped temporary tables are created and exist only for the duration of a transaction.
			They are accessible only within the transaction that created them and are automatically dropped when the transaction is committed or rolled back.
			CREATE TEMP TABLE
			
			
			
								-- Creating a session-scoped temporary table
					CREATE TEMPORARY TABLE TempResults (
						ID INT,
						Name VARCHAR(50),
						Age INT
					);

					-- Inserting data into the temporary table
					INSERT INTO TempResults (ID, Name, Age)
					VALUES
						(1, 'John', 30),
						(2, 'Alice', 28),
						(3, 'Michael', 35),
						(4, 'Sarah', 32),
						(5, 'David', 29);

					-- Retrieving data from the temporary table
					SELECT * FROM TempResults;

					-- Dropping the temporary table (it will be automatically dropped at the end of the session)
					DROP TEMPORARY TABLE TempResults;



Cte:
		CTE stands for Common Table Expression. 
		It is a temporary result set that can be referenced within a SELECT, INSERT, UPDATE, or DELETE statement in SQL.
		CTEs are mainly used to simplify complex queries and make them more readable and maintainable by breaking them down into smaller, logical parts.
		
	CTE to find employees with salaries greater than the average salary:

			Employee Table:

			EmployeeID	EmployeeName	Salary
					1	John	50000
					2	Alice	60000
					3	Michael	55000
					4	Sarah	65000
					5	David	52000
					
						WITH HighSalaryEmployees AS (
							SELECT EmployeeID, EmployeeName, Salary
							FROM Employee
							WHERE Salary > (SELECT AVG(Salary) FROM Employee)
						)
						SELECT * FROM HighSalaryEmployees;

					The CTE simplifies the query and allows you to use the intermediate result as if it were a regular table within the main SELECT statement. 
					This improves the querys readability and avoids the need for repeated subqueries
					
					
					
		Difference:

Temporary Tables are physical tables that are created explicitly, whereas CTEs are logical result sets defined within a single SQL query.
Temporary Tables are stored in temporary storage and survive beyond the immediate scope of the query, while CTEs are only available within the same query and automatically dropped after its execution.
Temporary Tables can be used across multiple queries and transactions, while CTEs are limited to the query where they are defined.
Temporary Tables can have indexes and can be optimized independently, while CTEs do not have physical storage and are optimized along with the entire query.			
					
6. find the age between 20 to 30

select * from Employee where empId between 20 And 30

7. change employee gender male yo female , female tomale from whole table


				UPDATE Employee
				SET Gender = 
					CASE 
						WHEN Gender = 'male' THEN 'female'
						WHEN Gender = 'female' THEN 'male'
						ELSE Gender -- Optional: To handle any other values, keep the existing value as is.
					END;

8.what is indexers

In SQL Server, indexes are database objects used to improve the performance of query execution by speeding up data retrieval. 

It works similarly to an index in a book, where you can quickly find the page number of a specific topic

Clustered Index: A clustered index determines the physical order of data within a table.
					Each table can have only one clustered index, and it determines the order in which the rows 

A non-clustered index is a separate data structure from the actual table data
					
9. what is cursor

A cursor  retrieve each row at a time and manipulate its data. always used in conjunction with a SELECT statement.
10 if we have managers table and employee table apply self join

9. what is Rank?



