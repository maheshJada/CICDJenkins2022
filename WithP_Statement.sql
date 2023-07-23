 
 --With clause using tempary table
with studentTemp([Id],[Class],[Name])
as (select [Id],[Class],[Name] from [Student])
select * from studentTemp



select * from [Student]
select * from Employee

 --With clause using tempary table with average function
with Avgsal([Emp_Id],[Salary])
as(select [Emp_Id],COUNT(*)as Salary from Employee group by [Emp_Id])
select [Emp_Id], Salary from Avgsal


 --With clause using 2 tables with inner join but it is not stored in database
with Student_Employee([Id],[Class],[Name],[Salary])
as (select s.[Id],s.[Class],s.[Name],e.[Salary]
from [Student] s inner join Employee e
on s.Id=e.Emp_Id)
select * from Student_Employee


--With clause using 2 tables with inner join but it is stored in database that name is with_Student_Employee
with Student_Employee([Id],[Class],[Name],[Salary])
as (select s.[Id],s.[Class],s.[Name],e.[Salary]
from [Student] s inner join Employee e
on s.Id=e.Emp_Id)
select * into with_Student_Employee from Student_Employee

--update statement in cte when u want to see the data it will change in real table also
with stu_Update([Id],[Class],[Name])
as (select [Id],[Class],[Name] from Student )
update stu_Update set [Class]=9  , [Name]='ramesh' where id=5

--Delete statement with

with Stu_Delete([id])
as (select [id] from Student)
delete from Stu_Delete where [id]=2


--Recursve commoon table expression




