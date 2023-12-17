use csc12002_21clc10_n10
go
-----------------------------------------------------------------

create or alter proc pr_reserve_schedule
	@date date,
	@shift_id smallint,
	@dentist char(10),
	@patient int,
	@type int
as
begin tran
declare cur cursor for select patient, date, shift_id from schedule
open cur
declare @patient1 varchar(12), @date1 date, @shift1 int
fetch next from cur into @department1,@patient1, @date1, @shift1
while @@FETCH_STATUS=0
begin
if (@date1 = @date and @shift1 = @shift_id and @patient1 = @patient )
begin
return 0
end
fetch next from cur into @patient1, @date1, @shift1
end
close cur
deallocate cur
update schedule set patient = @patient, type = @type where date = @date and shift_id = @shift_id and dentist = @dentist
commit tran
--------------------------------------------------------------------------------------
go
create or alter proc pr_cancel_reserved_schedule
	@date date,
	@shift_id smallint,
	@dentist char(10)
as
begin tran
update schedule set patient = NULL, type = NULL, accept = 0 where date = @date and shift_id = @shift_id and dentist = @dentist
commit tran
-------------------------------------------------------------------------------------
go
create or alter proc pr_update_schedule
	@date_old date,
	@date_new date,
	@shift_id_old smallint,
	@shift_id_new smallint,
	@dentist char(10)
as
begin tran
declare @patient varchar(12)
select @patient = patient from schedule where date = @date_old and shift_id = @shift_id_old and dentist = @dentist
if (@patient is not null)
begin
return 0
end
update schedule set date = @date_new, shift_id = @shift_id_new where date = @date_old and shift_id = @shift_id_old and dentist = @dentist
commit tran
-------------------------------------------------------------------------------------------

go
create or alter proc pr_add_schedule
	@date date,
	@shift_id smallint,
	@dentist char(10),
	@asisstant char(10)
as
begin tran
insert into schedule values (@date, @shift_id, @dentist ,NULL, @asisstant, NULL, NULL, 0)
commit tran
-------------------------------------------------------------------------------
go
create or alter proc pr_delete_schedule
	@date date,
	@shift_id smallint,
	@dentist char(10)
as
begin tran
declare @patient int
select @patient = patient from schedule where date = @date and shift_id = @shift_id and dentist = @dentist
if (@patient is not NULL)
begin
print 'khong the dieu chinh'
return 0
end
delete schedule where date = @date and shift_id = @shift_id and dentist = @dentist
commit tran
-------------------------------------------------------------------------------
go
create or alter proc pr_accept_schedule
	@date date,
	@shift_id smallint,
	@dentist char(10),
	@accept bit
as
begin tran
update schedule set accept = @accept where date = @date and shift_id = @shift_id and dentist = @dentist
commit tran
-------------------------------------------------------------------------
go
create or alter proc pr_re_examination_schedule_reserve
	@date date,
	@shift_id smallint,
	@dentist char(10),
	@patient int,
	@asisstant char(10),
	@last_treatment int
as
begin tran

if (not exists (select patient from schedule where date = @date and shift_id = @shift_id and dentist = @dentist))
begin
insert into schedule(date, shift_id, dentist, patient, assistant, type, accept) values (@date, @shift_id, @dentist ,@patient, @asisstant, @last_treatment, 1)
commit tran
end

declare cur cursor for select patient, date, shift_id from schedule
open cur
declare @patient1 varchar(12), @date1 date, @shift1 int
fetch next from cur into @patient1, @date1, @shift1
while @@FETCH_STATUS=0
begin
if (@date1 = @date and @shift1 = @shift_id and @patient1 = @patient )
begin
return 0
end
fetch next from cur into @patient1, @date1, @shift1
end
close cur
deallocate cur
update schedule set patient = @patient, type = @last_treatment, accept = 1 where date = @date and shift_id = @shift_id and dentist = @dentist
commit tran
----------------------------------------------------------------------------
go
create or alter proc pr_show_re_exam_schedule
	@last_treatment int
as
begin tran
select * from schedule where type = @last_treatment
commit tran
-----------------------------------------------------------------------------
go
create or alter proc pr_schedule_filter_by_dentist_reserve
	@dentist varchar(12)
as
BEGIN TRANSACTION;  
select * from schedule where datediff(d,date,getdate())<0 and dentist = @dentist
order by date asc, shift_id asc
COMMIT TRANSACTION;
--------------------------------------------------------------------------
go
create or alter proc pr_schedule_filter_by_dentist_archive
	@dentist varchar(12),
	@patient int
as
BEGIN TRANSACTION;  
select * from schedule where dentist = @dentist and @patient = @patient
order by date asc, shift_id asc
COMMIT TRANSACTION;
----------------------------------------------------------------------------
go
create or alter proc pr_schedule_filter_by_date_reserve
	@date date
as
BEGIN TRANSACTION;  
select * from schedule where date = @date
order by date asc, shift_id asc
COMMIT TRANSACTION;
-------------------------------------------------------
go
create or alter proc pr_schedule_filter_by_date_archive
	@date date,
	@patient int
as
BEGIN TRANSACTION;  
select * from schedule where date = @date and patient = @patient
order by date asc, shift_id asc
COMMIT TRANSACTION;
-------------------------------------------------------
go
create or alter proc pr_schedule_filter_by_both_reserve
	@dentist varchar(12),
	@date date
as
BEGIN TRANSACTION;  
select * from schedule where dentist = @dentist and date = @date
order by date asc, shift_id asc
COMMIT TRANSACTION;
-------------------------------------------------------
go
create or alter proc pr_schedule_filter_by_both_archive
	@dentist varchar(12),
	@date date,
	@patient int
as
BEGIN TRANSACTION;  \
select * from schedule where date = @date and dentist = @dentist and patient = @patient
order by date asc, shift_id asc
COMMIT TRANSACTION;
----------------------------------------------------
-----------------------------------------------------------

go
create or alter proc pr_get_all_dentist
	@department smallint
as
BEGIN TRANSACTION;
select distinct username, name from account_de where department = @department
COMMIT TRANSACTION;
------------------------------------------------------------------

go
create or alter proc pr_get_schedule
	@department smallint
as
BEGIN TRANSACTION;  
select * from schedule where datediff(d,date,getdate())<=0 and department = @department
order by date asc, shift_id asc
COMMIT TRANSACTION; 

	