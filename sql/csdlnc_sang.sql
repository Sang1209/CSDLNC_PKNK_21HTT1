use csc12002_21clc10_n10
go
create or alter proc themThuocChoKHDT @TreatmentID int,@MedicineID varchar(5),@amount int,@note varchar(100)
as 
set tran isolation level serializable
begin tran
if ((select Remain from Medicine)<@amount)
	begin
		return 0
	end
else
	begin
		update Medicine set Remain=Remain-@amount where Treatment=@TreatmentID and Medicine=@MedicineID
	end
insert into Prescription values(@TreatmentID,@MedicineID,@amount,@note)
commit tran
go
create or alter proc suaThuocChoKHDT @TreatmentID int,@MedicineID varchar(5),@amount int,@note varchar(100)
as 
set tran isolation level serializable
begin tran
declare @currentAmount as int = (select Quantity from Prescription where Treatment=@TreatmentID and Medicine=@MedicineID)
if ((select Remain from Medicine)<abs(@currentAmount-@amount))
	begin
		return 0
	end
else
	begin
		update Medicine set Remain=Remain-(@amount-@currentAmount) where Treatment=@TreatmentID and Medicine=@MedicineID
	end
update Prescription set Quantity=@amount,Note=@note where Treatment=@TreatmentID and Medicine=@MedicineID
commit tran
go
create or alter proc xoaThuocChoKHDT @TreatmentID int,@MedicineID varchar(5)
as 
set tran isolation level serializable
begin tran
declare @currentAmount as int= (select quantity from Prescription where Treatment=@TreatmentID and Medicine=@MedicineID)
update Medicine set Remain=Remain+@currentAmount where Treatment=@TreatmentID and Medicine=@MedicineID
delete from Prescription where Treatment=@TreatmentID and Medicine=@MedicineID
commit tran
go
create or alter proc xemKHDT @PatientID int
as
begin tran
select * from Treatment where Patient=@PatientID
commit tran
go
create or alter proc XemHoaDonCuaKH @PatientID int
as
begin tran
select p.* from (select TreatmentID,Patient) t join Payment p on t.TreatmentID=p.Treatment
where t.Patient=@PatientID
commit tran
go
--create or alter proc xemLichHenVoiBN @PatientID int, @DentistUsername
--as
--begin tran
--	select s.Date, a2.Name, a2.Phone, sp.From, sp.To, d.Address
--	from schedule s 
--	join Department d on s.depatment=d.departmentID 
--	join Shift_Period sp on s.Shift=sp.Shift_ID
--	join Account a2 on s.Assitant=a2.Username
--	where Dentist_Username=@DentistID and Patient=@PatientID
--commit tran