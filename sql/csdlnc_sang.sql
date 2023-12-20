use csc12002_21clc10_n10
go
create or alter proc themThuocChoKHDT @TreatmentID int,@MedicineID varchar(5),@amount int,@note varchar(100), @department int
as 
set tran isolation level serializable
begin tran
if ((select Remain from quantity_medicine where medicine = @MedicineID and department = @department)<@amount)
	begin
		return 0
	end
else
	begin
		update quantity_medicine set Remain=Remain-@amount where medicine=@MedicineID and department = @department
	end
insert into Prescription values(@TreatmentID,@MedicineID,@amount,@note)
commit tran
go




create or alter proc suaThuocChoKHDT @TreatmentID int,@MedicineID varchar(5),@amount int,@note varchar(100), @department int
as 
set tran isolation level serializable
begin tran
declare @currentAmount as int = (select Quantity from Prescription where Treatment=@TreatmentID and Medicine=@MedicineID)
if ((select Remain from quantity_medicine where medicine = @MedicineID and department = @department)<abs(@currentAmount-@amount))
	begin
		return 0
	end
else
	begin
		update quantity_medicine set Remain=Remain-(@amount-@currentAmount) where Medicine=@MedicineID and department = @department
	end
update Prescription set Quantity=@amount,Note=@note where Treatment=@TreatmentID and Medicine=@MedicineID
commit tran




go
create or alter proc xoaThuocChoKHDT @TreatmentID int,@MedicineID varchar(5), @department int
as 
set tran isolation level serializable
begin tran
declare @currentAmount as int= (select quantity from Prescription where Treatment=@TreatmentID and Medicine=@MedicineID)
update quantity_medicine set Remain=Remain+@currentAmount where Medicine=@MedicineID and department = @department
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
select p.* from (select ID,Patient from treatment where Patient=@PatientID) t join Payment p on t.ID=p.Treatment
commit tran
go

--select ID,Patient from treatment where id = (select treatment from payment where treatment = 210)
--exec XemHoaDonCuaKH @PatientID = 1250
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