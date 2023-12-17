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
@name varchar(20),
@gender char(1),
@phone varchar(12),
@email varchar(50),
@address varchar(50)
as
begin
    declare @Query nvarchar(MAX)
    set @Query = 'update account_adst set '
    if @name IS NOT NULL
        set @Query = @Query + '[name]' + ' = ''' + @name + ''', '
	if @gender IS NOT NULL
        set @Query = @Query + 'gender' + ' = ' + @gender + ', '
	if @phone IS NOT NULL
        set @Query = @Query + 'phone' + ' = ''' + @phone + ''', '
	if @email IS NOT NULL
        set @Query = @Query + 'email' + ' = ''' + @email + ''', '
	if @address IS NOT NULL
        set @Query = @Query + '[address]' + ' = ''' + @address + ''''
	if @Query = @Query + ' where username' + ' = ''' + @username + ''''

    exec sp_executesql @Query
end
--Sửa tài khoản nha sĩ
go
create or alter proc update_account_de
@username varchar(12),
@name varchar(20),
@gender char(1),
@phone varchar(12),
@email varchar(50),
@address varchar(50)
as
begin
    declare @Query nvarchar(MAX)
    set @Query = 'update account_de set '
    if @name IS NOT NULL
        set @Query = @Query + '[name]' + ' = ''' + @name + ''', '
	if @gender IS NOT NULL
        set @Query = @Query + 'gender' + ' = ' + @gender + ', '
	if @phone IS NOT NULL
        set @Query = @Query + 'phone' + ' = ''' + @phone + ''', '
	if @email IS NOT NULL
        set @Query = @Query + 'email' + ' = ''' + @email + ''', '
	if @address IS NOT NULL
        set @Query = @Query + '[address]' + ' = ''' + @address + ''''
	set @Query = @Query + ' where username' + ' = ''' + @username + ''''

    exec sp_executesql @Query
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
	where convert(date, t.[date]) = convert(date, getdate())
	group by medicine
	order by usage_count desc
end
--Thống kê thuốc theo tuần
go
create or alter proc pr_used_medicine_week
as
begin
	select medicine, count(*) as Usage_Count
	from prescription p join treatment t on p.treatment = t.id
	where t.[date] - dateadd(week, datediff(week, 0, getdate()), 0) >= 0
	group by medicine
	order by usage_count desc
end
--Thống kê thuốc theo tháng
go
create or alter proc pr_used_medicine_month
as
begin
	select medicine, count(*) as Usage_Count
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
create or alter proc pr_select_patient
as
begin
	select [name], birth, phone, email, [address], gender 
	from patient_profile
end
--Sửa hồ sơ bệnh nhân
go
create or alter proc pr_update_patient
@id varchar(6),
@name varchar(20),
@birth date,
@gender char(1),
@phone varchar(12),
@email varchar(50),
@address varchar(50)
as
begin
    declare @Query nvarchar(MAX)
    set @Query = 'update patient_profile set'
    if @name IS NOT NULL
        set @Query = @Query + '[name]' + ' = ''' + @name + ''', '
	if @birth IS NOT NULL
        set @Query = @Query + '[name]' + ' = ''' + @birth + ''', '
	if @gender IS NOT NULL
        set @Query = @Query + 'gender' + ' = ' + @gender + ', '
	if @phone IS NOT NULL
        set @Query = @Query + 'phone' + ' = ''' + @phone + ''', '
	if @email IS NOT NULL
        set @Query = @Query + 'email' + ' = ''' + @email + ''', '
	if @address IS NOT NULL
        set @Query = @Query + '[address]' + ' = ''' + @address + ''''
	set @Query = @Query + ' where id' + ' = ''' + @id + ''''

    exec sp_executesql @Query
end
----Xem danh sách nhân viên
go
create or alter proc pr_select_adst
as
begin
	select [name], phone, email, [address], gender
	from account_adst 
	where [admin] = 0
end
----Xem danh sách nha sĩ
go 
create or alter proc pr_select_de
as
begin
	select [name], phone, email, [address], gender, department 
	from account_de
end
--Xem lịch hẹn bản thân nha sĩ
go
create or alter proc pr_select_schedule_self
as
begin
	select [date], shift_id, patient, assistant, [type], department 
	from schedule 
end
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