create Database SqlInterview

/*Create the table with emp id as identity */ 

CREATE TABLE EmployeeDetail( [EmployeeID] INT IDENTITY(1,1) NOT NULL, [FirstName]
VARCHAR(50) NULL,
 [LastName] NVARCHAR(50) NULL, [Salary] DECIMAL(10, 2) NULL, [JoiningDate] DATETIME NULL,[Department] NVARCHAR(20) NULL,
 [Gender] VARCHAR(10) NULL)

 drop table EmployeeDetail
 select * from EmployeeDetail
 SELECT FirstName FROM EmployeeDetail
 --insert the data to the Employee details table
 insert into EmployeeDetail values('vikas','Ahlawat',600000.00,'2013-02-15 11:16:28.291','IT','Male');

 insert into EmployeeDetail values('nikita','Jain',530000.00,'2014-01-09 17:31:07.793','HR','FeMale');

 insert into EmployeeDetail values('Ashish','Kumar',1000000.00,'2014-01-09 10:05:07.793','IT','Male');

 insert into EmployeeDetail values('Nikhil','Sharma',480000.00,'2014-01-09 09:00:07.793','HR','FeMale');
 insert into EmployeeDetail values('anish','Kadian',500000.00,'2014-01-09 09:31:28.291','Payroll','FeMale');


 UPDATE EmployeeDetail
SET [JoiningDate]='2014-01-09 10:05:07.793'
WHERE Employee_ID=7369

select lower([FirstName]) as firstname from EmployeeDetail
select UPPER([FirstName]) as firstnames from EmployeeDetail

select Firstname +' '+lastname as Name from EmployeeDetail

select * from EmployeeDetail where Firstname='vikas'
select * from EmployeeDetail where Firstname like 'a%'
select * from EmployeeDetail where Firstname like '%k%'
select * from EmployeeDetail where Firstname like '%h'
select * from EmployeeDetail where Firstname like '[a-p]%'
select * from EmployeeDetail where Firstname like '[^a-p]%'

select * from EmployeeDetail where Gender like '__le'

select * from EmployeeDetail where Firstname like 'v____'

select Distinct(Department)From EmployeeDetail
select MAX(salary)  as highest from EmployeeDetail


CREATE TABLE EmployeeDetail( [EmployeeID] INT IDENTITY(1,1) NOT NULL, [FirstName]
VARCHAR(50) NULL,
 [LastName] NVARCHAR(50) NULL, [Salary] DECIMAL(10, 2) NULL, [JoiningDate] DATETIME NULL,[Department] NVARCHAR(20) NULL,
 [Gender] VARCHAR(10) NULL)

 create table Employeee(EmpID int , EmpName Varchar(30),PhNo int, deptid int, salary int) 

 create table Department(DeptID int, DeptName Varchar(30))

 select * from Employeee
 select Department.DeptName ,count(Employeee.EmpID) as EmployeeCount
 from Department 
 Inner Join Employeee on Employeee.deptid=Department.DeptID
 GROUP BY Department.Deptname;

 select Department.DeptName, Count(Employeee.EmpID) aS Employees
 from Department
 inner join Employeee on Employeee.deptid=Department.DeptID
 where Employeee.salary>1000
 group by  Department.DeptName
 having COUNT(Employeee.EmpID)>0
 order by Employees desc

 select Department.DeptName ,Employeee.EmpName, Employeee.salary , count(*) as
Employeess ,
sum(Employeee.salary) as TotalSalary
from Department,Employeee
where Department.DeptID = Employeee.deptid
group by Department.DeptName ,Employeee.EmpName, Employeee.salary 

select DeptID, count(*)
 from Employeee
 Group by DeptID




--it is find the toatl salary based on departmet(like it will calculate the 2 same dept)
 select Department.DeptName , count(Employeee.EmpID) as Employeess ,
sum(Employeee.salary) as TotalSalary
from Department,Employeee
where  Department.DeptID = Employeee.deptid
group by Department.DeptName 


WITH CTE_Employee AS
(
select Department.DeptName , count(Employeee.EmpID) as Employeess ,
sum(Employeee.salary) as TotalSalary
from Department,Employeee
where  Department.DeptID = Employeee.deptid
group by Department.DeptName 
)
SELECT DeptName, Employeess, TotalSalary
FROM CTE_Employee

 alter table Employeee 
 add mangerid int

 update Employeee set mangerid=1 where Employeee.EmpID=2

 alter table Employeee
 drop column mangerid

 alter table Employeee
 alter column mangerid varchar(30)

 select Count(*)From EmployeeDetail


 select count(*) as EmployeeCount from Employeee 

 --// check what table is in inside
 select * from INFORMATION_SCHEMA.TABLES
  select * from Employeee
  select top 2 * from Employeee
  select distinct EmpID from Employeee


  --get a unique sequential number for each row
--get different ranks for the row having similar values

  SELECT *,
 ROW_NUMBER() OVER(ORDER BY Salary DESC) SalaryRank
FROM Employeee

--specify rank for each row in the result set
--use PARTITION BY to performs calculation on each group
--each subset get rank as per Salary in descending order

SELECT *,
 RANK() OVER(PARTITION BY EmpName ORDER BY Salary DESC)
SalaryRank
FROM Employeee
ORDER BY EmpName, SalaryRank-- get SAME ranks for the row having similar valuesSELECT *,
 RANK() OVER(ORDER BY Salary DESC) SalaryRank
FROM Employeee
ORDER BY SalaryRank-- if have duplicate values, SQL assigns different ranks to those rows.
-- will get the same rank for duplicate or similar valuesSELECT *,
 DENSE_RANK() OVER(ORDER BY Salary DESC) SalaryRank
FROM Employeee
ORDER BY SalaryRank

  select * into TempTable from Employeee
  select * from TempTable

  Select Employeee.EmpName, LTRIM(Employeee.EmpName) as IDLTRIM
FROM Employeee 