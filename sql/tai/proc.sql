use [csc12002_21clc10_n10]

-- Thêm tài khoản nhân viên, quản trị viên
go
create or alter proc add_account_adst
@username varchar(12),
@password varchar(50),
@name varchar(20),
@gender bit,
@type bit,
@phone varchar(12),
@email varchar(50),
@address varchar(50)
as
begin
	insert into account_adst (username, [password], [name], gender, [admin], phone, email, [address])
	values (@username, @password, @name, @gender, @type, @phone, @email, @address)
end
-- Thêm tài khoản nha sĩ
go
create or alter proc add_account_de
@username varchar(12),
@password varchar(50),
@name varchar(20),
@gender bit,
@department bit,
@phone varchar(12),
@email varchar(50),
@address varchar(50)
as
begin
	insert into account_de(username, [password], [name], gender, department, phone, email, [address])
	values (@username, @password, @name, @gender, @department, @phone, @email, @address)
end
--Sửa tài khoản nhân viên, quản trị viên
go
create or alter proc update_account_adst
@username varchar(12),
@password varchar(30),
@name varchar(20),
@gender bit,
@phone varchar(12),
@email varchar(50),
@address varchar(50),
@admin bit
as
begin
    update account_adst
	set username = @username,
		password = @password,
		name = @name,
		gender = @gender,
		phone = @phone,
		email = @email,
		address = @address,
		admin = @admin
	where username = @username
end
--Sửa tài khoản nha sĩ
go
create or alter proc update_account_de
@username varchar(10),
@password varchar(30),
@name varchar(20),
@gender bit,
@phone varchar(12),
@email varchar(50),
@address varchar(50),
@department smallint
as
begin
    update account_de
	set username = @username,
		password = @password,
		name = @name,
		gender = @gender,
		phone = @phone,
		email = @email,
		address = @address,
		department = @department
	where username = @username
end
--Đổi mật khẩu nhân viên, quản trị viên
go
create or alter proc pr_change_password_stad
@username varchar(12),
@password nvarchar(50)
as
begin
	update account_adst
	set [password] = @password
	where username = @username
end
--Đổi mật khẩu nha sĩ
go
create or alter proc pr_change_password_de
@username varchar(12),
@password nvarchar(50)
as
begin
	update account_de
	set [password] = @password
	where username = @username
end
--Cấp/gỡ quyền quản trị viên
go
create or alter proc pr_change_type_stad
@username varchar(12),
@type bit
as
begin
	update account_adst
	set [admin] = [admin]^1
	where username = @username
end
--Thống kê thuốc theo ngày
go
create or alter proc pr_used_medicine_day
as
begin
	select medicine, sum(quantity) as usage_count
	from prescription p join treatment t on p.treatment = t.id
	where datediff(day, t.[date], getdate()) = 0
	group by medicine
	order by usage_count desc
end

--Thống kê thuốc theo tháng
go
create or alter proc pr_used_medicine_month
as
begin
	select medicine, count(medicine) as Usage_Count
	from prescription p join treatment t on p.treatment = t.id
	where year(t.[date]) = year(getdate())
		  and month(t.[date]) = month(getdate())
	group by medicine
	order by usage_count desc
end
--Thêm hồ sơ bệnh nhân
go 
create or alter proc pr_create_patient
@name varchar(20),
@birth date,
@phone varchar(12),
@email varchar(50),
@address varchar(50),
@gender bit
as
begin
	declare @id int
	if exists (select 1 from patient_profile)
	begin
		set @id = (select MAX(id) from patient_profile) + 1
	end
	else
	begin
		set @id = 1
	end
	insert into patient_profile (id, [name], birth, phone, email, [address], gender, bill, paid, overall_condition, contraindicated_note)
	values (@id, @name, @birth, @phone, @email, @address, @gender, 0, 0, null, null)
end
--Xem hồ sơ bệnh nhân
go 
create or alter proc pr_view_patient
as
begin
	select [name], birth, phone, email, [address], gender 
	from patient_profile
end
--Sửa hồ sơ bệnh nhân
go
create or alter proc pr_update_patient
@id int,
@name varchar(20),
@birth date,
@gender bit,
@phone varchar(12),
@email varchar(50),
@address varchar(50)
as
begin
    update patient_profile
	set [name] = @name,
		birth = @birth,
		gender = @gender,
		phone = @phone,
		email = @email,
		[address] = @address
	where id = @id
end
----Xem danh sách nhân viên
go
create or alter proc pr_view_adst
as
begin
	select [name], phone, email, [address], gender
	from account_adst 
	where [admin] = 0
end
------Xem danh sách nha sĩ
--go 
--create or alter proc pr_select_de
--as
--begin
--	select [name], phone, email, [address], gender, department 
--	from account_de
--end
----Xem lịch hẹn bản thân nha sĩ
--go
--create or alter proc pr_select_schedule_self
--as
--begin
--	select [date], shift_id, patient, assistant, [type], department 
--	from schedule 
--end
--Thêm/cập nhật thông tin sức khỏe bệnh nhân
go
create or alter proc pr_create_patient_condition
@id int,
@condition varchar(100)
as
begin
	update patient_profile
	set overall_condition = @condition
	where id = @id
end

go
create or alter proc layDSDiUng
as
begin tran
select top 100 c.patient,p.name as pName,c.medicine,m.name as medName from contraindicated c join (select id,name from patient_profile) p on p.id=c.patient join medicine m on c.medicine=m.id
commit tran
go
create or alter proc layDSDiUngTheoBN @pID int
as
begin tran
select c.patient,p.name as pName,c.medicine,m.name as medName from contraindicated c join (select id,name from patient_profile) p on p.id=c.patient join medicine m on c.medicine=m.id
where c.patient=@pID
commit tran
go
create or alter proc themDiUng @pID int,@mID varchar(5)
as
begin tran
	insert into contraindicated values (@pID,@mID)
commit tran
go
create or alter proc xoaDiUng @pID int,@mID varchar(5)
as
begin tran
delete from contraindicated where patient=@pID and medicine=@mID
commit tran
go
create or alter proc capNhatDiUng @pID int,@mID_old varchar(5),@mID_new varchar(5)
as
begin tran
update contraindicated set medicine=@mID_new where patient=@pID and medicine=@mID_old
commit tran
go


