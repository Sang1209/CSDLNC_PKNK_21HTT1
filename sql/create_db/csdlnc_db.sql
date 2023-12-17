use master
go
--drop database csc12002_21clc10_n10
create database csc12002_21clc10_n10
go
use csc12002_21clc10_n10
go

create table account_de (
	username char(10) not null primary key,
	password varchar(30) not null,
	name varchar(20) not null,
	phone varchar(12) not null,
	email varchar(50),
	address varchar(50) not null,
	gender bit not null,
	department smallint not null,
)

create table account_adst (
	username char(10) not null primary key,
	password varchar(30) not null,
	name varchar(20) not null,
	phone varchar(12) not null,
	email varchar(50),
	address varchar(50) not null,
	gender bit not null,
	admin bit not null,
)

create table department (
	id smallint not null primary key,
	address varchar(50) not null,
)

-------------------------------------------------------------------------------------

--ALTER DATABASE csc12002_21clc10_n10 
--ADD FILEGROUP fg_schedule_department1;  
--GO  
--ALTER DATABASE csc12002_21clc10_n10 
--ADD FILEGROUP fg_schedule_department2;  
--GO  
--ALTER DATABASE csc12002_21clc10_n10 
--ADD FILEGROUP fg_schedule_department3;  
--GO  
--ALTER DATABASE csc12002_21clc10_n10 
--ADD FILEGROUP fg_schedule_department4;  
--GO  
--ALTER DATABASE csc12002_21clc10_n10 
--ADD FILEGROUP fg_schedule_department5;  
--GO  

--ALTER DATABASE csc12002_21clc10_n10   
--ADD FILE   
--(  
--    NAME = schedule_department1,  
--    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\schedule_department1.ndf',  
--    SIZE = 5MB,  
--    FILEGROWTH = 5MB  
--)  
--TO FILEGROUP fg_schedule_department1;  
--ALTER DATABASE csc12002_21clc10_n10   
--ADD FILE   
--(  
--    NAME = schedule_department2,  
--    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\schedule_department2.ndf',  
--    SIZE = 5MB,  
--    FILEGROWTH = 5MB  
--)  
--TO FILEGROUP fg_schedule_department2;  
--ALTER DATABASE csc12002_21clc10_n10   
--ADD FILE   
--(  
--    NAME = schedule_department3,  
--    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\schedule_department3.ndf',  
--    SIZE = 5MB,  
--    FILEGROWTH = 5MB  
--)  
--TO FILEGROUP fg_schedule_department3;  
--ALTER DATABASE csc12002_21clc10_n10   
--ADD FILE   
--(  
--    NAME = schedule_department4,  
--    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\schedule_department4.ndf',  
--    SIZE = 5MB,  
--    FILEGROWTH = 5MB  
--)  
--TO FILEGROUP fg_schedule_department4;  
--ALTER DATABASE csc12002_21clc10_n10   
--ADD FILE   
--(  
--    NAME = schedule_department5,  
--    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\schedule_department5.ndf',  
--    SIZE = 5MB,  
--    FILEGROWTH = 5MB  
--)  
--TO FILEGROUP fg_schedule_department5;  

--CREATE PARTITION FUNCTION PF_schedule (smallint)  
--    AS RANGE RIGHT FOR VALUES (3,5,7,9) ;  
--GO  

--CREATE PARTITION SCHEME PS_schedule  
--    AS PARTITION PF_schedule  
--    ALL TO ('PRIMARY') ;  
--GO  

create table schedule (
	date date not null,
	shift_id smallint not null,
	dentist char(10) not null,
	patient int,
	assistant char(10),
	type int,
	department smallint not null,
	accept bit not null,
	constraint pk_schedule primary key (date,shift_id,dentist)
)
--ON PS_schedule (department)
go


----------------------------------------------------------------------------------------


create table shift_period (
	id smallint not null primary key,
	start time not null,
	finish time not null,
)

create table patient_profile (
	id int not null primary key,
	name varchar(20) not null,
	birth date not null,
	phone varchar(12) not null,
	email varchar(50),
	address varchar(50) not null,
	gender bit not null,
	bill float,
	paid float,
	overall_condition varchar(100),
	contraindicated_note varchar(100),
)

create table contraindicated (
	patient int not null,
	medicine varchar(5) not null,
	constraint pk_contraindicated primary key (patient,medicine)
)
--go
--CREATE INDEX primary_contraindicated
--ON contraindicated (patient,medicine)

create table treatment (
	id int not null primary key,
	department smallint not null,
	dentist char(10) not null,
	patient int not null,
	assistant char(10),
	description varchar(100),
	date date not null,
	note varchar(100),
	method smallint,
	tooth smallint,
	state smallint,
	total float
)

create table treatment_list (
	id smallint not null primary key,
	name varchar(50) not null,
)

create table tooth_list (
	id smallint not null primary key,
	name varchar(10) not null,
)

create table payment (
	treatment int not null,
	num smallint not null,
	total float not null,
	given float not null,
	method smallint not null,
	date date not null,
	payer varchar(20) not null,
	note varchar(100),
	constraint pk_payment primary key (treatment,num)
	
)

go
create trigger payment_no on payment for insert
as
begin
update payment
set num = (select count(treatment) from payment where treatment = (select treatment from inserted))
end
go


create table payment_method (
	id smallint not null primary key,
	name varchar(20) not null,
)

create table prescription (
	treatment int not null,
	medicine varchar(5) not null,
	quantity int not null,
	note varchar(100),
	constraint pk_presription primary key (treatment,medicine)
)



create table medicine (
	id varchar(5) not null primary key,
	name varchar(20) not null,
)

create table quantity_medicine (
	medicine varchar(5) not null,
	department smallint not null,
	remain int not null,
	constraint pk_quantity_medicine primary key (department,medicine)
)


go
alter table account_de add foreign key (department) references department(id)

alter table schedule add foreign key (dentist) references account_de(username)
alter table schedule add foreign key (assistant) references account_de(username)
alter table schedule add foreign key (department) references department(id)
alter table schedule add foreign key (shift_id) references shift_period(id)
alter table schedule add foreign key (patient) references patient_profile(id)

alter table schedule add foreign key (type) references treatment(id)
alter table contraindicated add foreign key (patient) references patient_profile(id)
alter table contraindicated add foreign key (medicine) references medicine(id)

alter table treatment add foreign key (dentist) references account_de(username)
alter table treatment add foreign key (assistant) references account_de(username)
alter table treatment add foreign key (department) references department(id)
alter table treatment add foreign key (patient) references patient_profile(id)
alter table treatment add foreign key (method) references treatment_list(id)
alter table treatment add foreign key (tooth) references tooth_list(id)

alter table payment add foreign key (method) references payment_method(id)
alter table payment add foreign key (treatment) references treatment(id)

alter table prescription add foreign key (treatment) references treatment(id)
alter table prescription add foreign key (medicine) references medicine(id)

alter table quantity_medicine add foreign key (medicine) references medicine(id)
alter table quantity_medicine add foreign key (department) references department(id)








