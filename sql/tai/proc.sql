use [csc12002_21clc10_n10]

-- Thêm tài khoản nhân viên, quản trị viên
go
create or alter proc add_account_ad_st
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
	insert into ACCOUNT_AD_ST (Staff_Username, Staff_Password, Staff_Name, Staff_Gender, Staff_Type, Staff_Phone, Staff_Email, Staff_Address)
	values (@username, @password, @name, @gender, @type, @phone, @email, @address)
end
-- Thêm tài khoản nha sĩ
go
create or alter proc add_account_dt
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
	insert into ACCOUNT_DT (Dentist_Username, Dentist_Password, Dentist_Name, Dentist_Gender, Dentist_Department, Dentist_Phone, Dentist_Email, Dentist_Address)
	values (@username, @password, @name, @gender, @department, @phone, @email, @address)
end
--Sửa tài khoản nhân viên, quản trị viên
go
create or alter proc update_account_ad_st
@username varchar(12),
@name varchar(20),
@gender char(1),
@phone varchar(12),
@email varchar(50),
@address varchar(50)
as
begin
    declare @Query nvarchar(MAX)
    set @Query = 'update ACCOUNT_AD_ST set '
    if @name IS NOT NULL
        set @Query = @Query + 'Staff_Name' + ' = ''' + @name + ''', '
	if @gender IS NOT NULL
        set @Query = @Query + 'Staff_Gender' + ' = ' + @gender + ', '
	if @phone IS NOT NULL
        set @Query = @Query + 'Staff_Phone' + ' = ''' + @phone + ''', '
	if @email IS NOT NULL
        set @Query = @Query + 'Staff_Email' + ' = ''' + @email + ''', '
	if @address IS NOT NULL
        set @Query = @Query + 'Staff_Address' + ' = ''' + @address + ''''
	if @Query = @Query + ' where Staff_username' + ' = ''' + @username + ''''

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
    set @Query = 'update ACCOUNT_DT set '
    if @name IS NOT NULL
        set @Query = @Query + 'Dentist_Name' + ' = ''' + @name + ''', '
	if @gender IS NOT NULL
        set @Query = @Query + 'Dentist_Gender' + ' = ' + @gender + ', '
	if @phone IS NOT NULL
        set @Query = @Query + 'Dentist_Phone' + ' = ''' + @phone + ''', '
	if @email IS NOT NULL
        set @Query = @Query + 'Dentist_Email' + ' = ''' + @email + ''', '
	if @address IS NOT NULL
        set @Query = @Query + 'Dentist_Address' + ' = ''' + @address + ''''
	set @Query = @Query + ' where Dentist_username' + ' = ''' + @username + ''''

    exec sp_executesql @Query
end
--Đổi mật khẩu nhân viên, quản trị viên
go
create or alter proc pr_change_password_st_ad
@username varchar(12),
@password nvarchar(50)
as
begin
	update ACCOUNT_AD_ST
	set Staff_password = @password
	where Staff_username = @username
end
--Đổi mật khẩu nha sĩ
go
create or alter proc pr_change_password_de
@username varchar(12),
@password nvarchar(50)
as
begin
	update ACCOUNT_DE
	set Dentist_password = @password
	where Dentist_username = @username
end
--Cấp/gỡ quyền quản trị viên
go
create or alter proc pr_change_type_st_ad
@username varchar(12),
@type bit
as
begin
	update ACCOUNT_AD_ST
	set Staff_type = Staft_type^1
	where Staff_username = @username
end
--Thống kê thuốc theo ngày
go
create or alter proc pr_used_medicine_day
as
begin
	select Prescription_Medicine, count(*) as Usage_Count
	from Prescription p join TREATMENT t on p.Prescription_Treatment = t.TreatmentID
	where convert(date, t.Treatment_Date) = convert(date, getdate())
	group by Prescription_Medicine
	order by Usage_Count desc
end
--Thống kê thuốc theo tuần
go
create or alter proc pr_used_medicine_week
as
begin
	select Prescription_Medicine, count(*) as Usage_Count
	from Prescription p join TREATMENT t on p.Prescription_Treatment = t.TreatmentID
	where t.Treatment_Date - dateadd(week, datediff(week, 0, getdate()), 0) >= 0
	group by Prescription_Medicine
	order by Usage_Count desc
end
--Thống kê thuốc theo tháng
go
create or alter proc pr_used_medicine_month
as
begin
	select Prescription_Medicine, count(*) as Usage_Count
	from Prescription p join TREATMENT t on p.Prescription_Treatment = t.TreatmentID
	where year(t.Treatment_Date) = year(getdate())
		  and month(t.Treatment_Date) = month(getdate())
	group by Prescription_Medicine
	order by Usage_Count desc
end