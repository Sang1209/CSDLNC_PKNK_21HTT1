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
ALTER DATABASE csc12002_21clc10_n10
ADD FILEGROUP fg_schedule_date1;  
GO  
ALTER DATABASE csc12002_21clc10_n10 
ADD FILEGROUP fg_schedule_date2;  
GO  
ALTER DATABASE csc12002_21clc10_n10 
ADD FILEGROUP fg_schedule_date3;  
GO  
ALTER DATABASE csc12002_21clc10_n10 
ADD FILEGROUP fg_schedule_date4;  
GO  

ALTER DATABASE csc12002_21clc10_n10   
ADD FILE   
(  
    NAME = schedule_date1,  
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\schedule_date1.ndf',  
    SIZE = 50MB,  
    FILEGROWTH = 5MB  
)  
TO FILEGROUP fg_schedule_date1;  
ALTER DATABASE csc12002_21clc10_n10   
ADD FILE   
(  
    NAME = schedule_date2,  
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\schedule_date2.ndf',  
    SIZE = 50MB,  
    FILEGROWTH = 5MB  
)  
TO FILEGROUP fg_schedule_date2;  
ALTER DATABASE csc12002_21clc10_n10   
ADD FILE   
(  
    NAME = schedule_date3,  
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\schedule_date3.ndf',  
    SIZE = 50MB,  
    FILEGROWTH = 5MB  
)  
TO FILEGROUP fg_schedule_date3;  
ALTER DATABASE csc12002_21clc10_n10   
ADD FILE   
(  
    NAME = schedule_date4,  
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\schedule_date4.ndf',  
    SIZE = 50MB,  
    FILEGROWTH = 5MB  
)  
TO FILEGROUP fg_schedule_date4;  


CREATE PARTITION FUNCTION PF_schedule (date)  
    AS RANGE RIGHT FOR VALUES ('1-1-2015','1-1-2019','1-1-2022','1-1-2023');  
GO  

CREATE PARTITION SCHEME PS_schedule  
    AS PARTITION PF_schedule  
    ALL TO ('PRIMARY') ;  
GO  
create table schedule (
	date date not null,
	shift_id smallint not null,
	dentist char(10) not null,
	den_name varchar(20),
	pat_name varchar(20),
	ass_name varchar(20),
	patient int,
	assistant char(10),
	type int,
	department smallint,
	accept bit not null,
	constraint pk_schedule primary key (date,shift_id,dentist)
)ON PS_schedule (date)

go
create or alter trigger schedule_reexamdate on schedule for insert
as
begin
declare @tmp int
set @tmp = (select type from inserted)
if @tmp is not Null
begin
if datediff(d,(select date from inserted),(select date from treatment where id = @tmp)) < 0
begin
update schedule
set department = (select department from account_de where username = (select dentist from inserted))
where date = (select date from inserted) and shift_id = (select shift_id from inserted) and dentist = (select dentist from inserted)
end
else
begin
update schedule
set type = null, department = (select department from account_de where username = (select dentist from inserted))
where date = (select date from inserted) and shift_id = (select shift_id from inserted) and dentist = (select dentist from inserted)
end
end
end
go

go
create or alter trigger schedule_name on schedule for insert, update
as
begin
if (select assistant from inserted) is not null
begin
	update schedule
	set ass_name = (select top 1 name from account_de where username = (select assistant from inserted))
	where date = (select date from inserted) and shift_id = (select shift_id from inserted) and dentist = (select dentist from inserted)
end
if (select dentist from inserted) is not null
begin
	update schedule
	set den_name = (select top 1 name from account_de where username = (select dentist from inserted))
	where date = (select date from inserted) and shift_id = (select shift_id from inserted) and dentist = (select dentist from inserted)
end
if (select patient from inserted) is not null
begin
	update schedule
	set pat_name = (select top 1 name from patient_profile where id = (select patient from inserted))
	where date = (select date from inserted) and shift_id = (select shift_id from inserted) and dentist = (select dentist from inserted)
end
end
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
	department smallint,
	dentist char(10) not null,
	patient int not null,
	assistant char(10),
	den_name varchar(20),
	pat_name varchar(20),
	ass_name varchar(20),
	description varchar(100),
	date date not null,
	note varchar(100),
	method smallint,
	tooth smallint,
	state smallint,
	total float
)

go
create or alter trigger treatment_department on treatment for insert
as
begin
update treatment
set department = (select department from account_de where username = (select dentist from inserted))
end
go


go
create or alter trigger treatment_name on treatment for insert
as
begin
--if ((select assistant from inserted) is not null)
--begin
	update treatment
	set ass_name = 'o'
	where id = (select id from inserted)
--end
--if ((select dentist from inserted) is not null)
--begin
--	update treatment
--	set den_name = (select top 1 name from account_de where username = (select dentist from inserted))
--	where id = (select id from inserted)
--end
--if ((select patient from inserted) is not null)
--begin
--	update treatment
--	set pat_name = (select top 1 name from patient_profile where id = (select patient from inserted))
--	where id = (select id from inserted)
--end
end
go



create table treatment_list (
	id smallint not null primary key,
	name varchar(50) not null,
	price float not null
)

create table tooth_list (
	id smallint not null primary key,
	name varchar(10) not null,
)

create table payment (
	treatment int not null,
	num smallint not null,
	change float not null,
	need float not null,
	method smallint not null,
	date date not null,
	payer varchar(20) not null,
	note varchar(100),
	constraint pk_payment primary key (treatment,num)
	
)

go
create trigger payment_no on payment after insert
as
begin
declare @tmp float
select @tmp = total from treatment where id = (select treatment from inserted) 
if @tmp - (select sum(need) from payment where treatment = (select treatment from inserted) ) <= 0 
begin
update payment
set num = (select count(treatment) from payment where treatment = (select treatment from inserted))
update patient_profile
set paid = paid + (select need from inserted) where id = (select patient from treatment where id = (select treatment from inserted))
end
else
begin
delete payment where treatment = (select treatment from inserted) and num = (select num from inserted)
end
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
	price float not null
)

create table quantity_medicine (
	medicine varchar(5) not null,
	department smallint not null,
	remain int not null,
	constraint pk_quantity_medicine primary key (department,medicine)
)

go
create or alter trigger treatment_total_add_medicine on prescription for insert
as
begin
declare @tmp float
set @tmp = (select quantity from inserted) * (select price from medicine where id = (select medicine from inserted))
update treatment
set total = total + @tmp
where id = (select treatment from inserted)
update patient_profile
set bill = bill + @tmp
where id = (select patient from treatment where id = (select treatment from inserted))
end
go

go
create or alter trigger treatment_total_remove_medicine on prescription for delete
as
begin
declare @tmp float
set @tmp = (select quantity from inserted) * (select price from medicine where id = (select medicine from inserted))
update treatment
set total = total - @tmp
where id = (select treatment from inserted)
update patient_profile
set bill = bill - @tmp
where id = (select patient from treatment where id = (select treatment from inserted))
end
go

go
create or alter trigger treatment_total_update_medicine on prescription for update
as
begin
declare @tmp float
select @tmp = (select price from medicine where id = (select medicine from deleted))
set @tmp = - (select quantity from deleted) * @tmp + (select quantity from inserted) * @tmp
update treatment
set total = total + @tmp
where id = (select treatment from inserted)
update patient_profile
set bill = bill + @tmp
where id = (select patient from treatment where id = (select treatment from inserted))
end
go

go
create or alter trigger treatment_total_treatment on treatment for insert
as
begin
declare @tmp float
select @tmp = (select price from treatment_list where id = (select method from inserted))
update treatment
set total = total + @tmp 
where id = (select method from inserted)
update patient_profile
set bill = bill + @tmp
where id = (select method from inserted)
end
go

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

CREATE INDEX quantity_medicine1
ON quantity_medicine (medicine,department);

CREATE INDEX prescription1
ON prescription (treatment,medicine);

CREATE INDEX treatment1
ON treatment (patient)
INCLUDE (id);

CREATE INDEX treatment2
ON treatment (date);

CREATE INDEX schedule1
ON schedule (dentist,patient);

CREATE INDEX schedule2
ON schedule (date,dentist,patient);

CREATE INDEX schedule3
ON schedule (date,patient);

CREATE INDEX schedule4
ON schedule (date,dentist);

CREATE INDEX schedule5
ON schedule (date,department);

CREATE INDEX schedule6
ON schedule (department);


create or alter proc fix1
as
begin
declare cur cursor for select treatment from payment group by treatment having count(num) >= 2
declare @treatment int
open cur
fetch next from cur into @treatment
while @@FETCH_STATUS=0
	begin
	declare cur1 cursor for select num from payment where treatment = @treatment
	declare @k int = 1, @num int
	open cur1
	fetch next from cur1 into @num
	while @@FETCH_STATUS=0
		begin
		update payment set num = @k where treatment = @treatment and num = @num
		set @k = @k + 1
		print @k
		fetch next from cur1 into @num
		end
	close cur1
	deallocate cur1
	fetch next from cur into @treatment
	end
close cur
deallocate cur
end

go
create or alter proc fix2
as 
begin
update schedule set accept = 0 where patient is NULL
end

go
create or alter proc fix3
as
begin
declare cur cursor for select date, shift_id, dentist from schedule
declare @dentist char(10), @date date, @shift_id int
open cur
fetch next from cur into @date, @shift_id, @dentist
while @@FETCH_STATUS=0
	begin
	update schedule
	set department = (select department from account_de where username = @dentist) where date = @date and shift_id = @shift_id and dentist = @dentist
	fetch next from cur into @date, @shift_id, @dentist
	end
close cur
deallocate cur
end

go
create or alter proc fix4
as
begin
declare cur cursor for select id, dentist from treatment
declare @dentist char(10), @id int
open cur
fetch next from cur into @id, @dentist
while @@FETCH_STATUS=0
	begin
	update treatment
	set department = (select department from account_de where username = @dentist) where id = @id
	fetch next from cur into @id, @dentist
	end
close cur
deallocate cur
end

go
create or alter proc fix5
as
begin
declare cur cursor for select id, assistant, department from treatment
declare @assistant char(10), @id int, @department smallint
open cur
fetch next from cur into @id, @assistant, @department
while @@FETCH_STATUS=0
begin
	if (select department from account_de where username = @assistant) <> @department
	begin
	update treatment
	set assistant = null where id = @id
	end
fetch next from cur into @id, @assistant, @department
end
close cur
deallocate cur
end
go

go
create or alter proc fix6
as
begin
declare cur cursor for select date, shift_id, dentist, assistant, department from schedule
declare @dentist char(10), @date date, @shift_id int, @assistant char(10), @department smallint
open cur
fetch next from cur into @date, @shift_id, @dentist, @assistant, @department
while @@FETCH_STATUS=0
	begin
	if (select department from account_de where username = @assistant) <> @department
	begin
	update schedule
	set assistant = null where date = @date and shift_id = @shift_id and dentist = @dentist
	end
fetch next from cur into @date, @shift_id, @dentist, @assistant, @department
end
close cur
deallocate cur
end
go









