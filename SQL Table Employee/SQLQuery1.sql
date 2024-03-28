Create Table Employees
(
        id int primary key Identity(1,1),
        employee_id varchar(max) NULL,
        full_name varchar(max) Null,
        gender Varchar(max) Null,
        contact_number varchar(max) Null,
        position Varchar(max) Null,
        image Varchar(max) Null,
        salary INT Null,
        insert_date Date Null,
        update_date date Null,
        delete_date date Null,

)
SELECT * FROM Employees

alter table Employees
Add  status varchar(max) Null

select * from Employees Where delete_date IS NULL