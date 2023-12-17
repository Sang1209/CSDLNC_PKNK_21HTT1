use csc12002_21clc10_n10
go
create or alter proc themThuocChoKHDT @TreatmentID int,@MedicineID varchar(5),@amount int,@note varchar(100)
as 
set tran isolation level serializable
begin tran
declare @dep as int=(select top 1 department from treatment where id=@TreatmentID)
if ((select remain from quantity_medicine where department=@dep and medicine=@MedicineID)<@amount)
	begin
		return 0
	end
else
	begin
		update quantity_medicine set Remain=Remain-@amount where Medicine=@MedicineID and department=@dep
	end
insert into Prescription values(@TreatmentID,@MedicineID,@amount,@note)
commit tran
go

create or alter proc suaThuocChoKHDT @TreatmentID int,@MedicineID varchar(5),@amount int,@note varchar(100)
as 
set tran isolation level serializable
begin tran
declare @currentAmount as int = (select Quantity from Prescription where Treatment=@TreatmentID and Medicine=@MedicineID)
declare @curDep as int = (select department from treatment where id=@TreatmentID)
update quantity_medicine set remain=remain+@currentAmount where department=@curDep and medicine=@MedicineID
if ((select remain from quantity_medicine where department=@curDep and medicine=@MedicineID)<@amount)
	begin
		return 0
	end
else
	begin
		update quantity_medicine set Remain=Remain-@amount where department=@curDep and medicine=@MedicineID
	end
update Prescription set Quantity=@amount,Note=@note where Treatment=@TreatmentID and Medicine=@MedicineID
commit tran
go
create or alter proc xoaThuocChoKHDT @TreatmentID int,@MedicineID varchar(5)
as 
set tran isolation level serializable
begin tran
declare @currentAmount as int= (select quantity from Prescription where Treatment=@TreatmentID and Medicine=@MedicineID)
declare @curDep as int = (select department from treatment where id=@TreatmentID)
update quantity_medicine set Remain=Remain+@currentAmount where department=@curDep and medicine=@MedicineID
delete from Prescription where Treatment=@TreatmentID and Medicine=@MedicineID
commit tran
go
create or alter proc xemKHDT @PatientID int
as
begin tran
select t.id,d.address,t.dentist,t.patient,t.assistant,t.description,t.date,t.note,tl.name as method,tol.name as tooth_name,t.state,t.total
from Treatment t
join department d on t.department=d.id
join treatment_list tl on t.method=tl.id
join tooth_list tol on t.tooth=tol.id
where Patient=@PatientID
commit tran
go
create or alter proc XemHoaDonCuaKH @PatientID int
as
begin tran
select p.* from (select id,Patient from treatment) t join Payment p on t.id=p.Treatment
where t.Patient=@PatientID
commit tran
go
create or alter proc xemLichHenTrongNgay
as
begin tran
	select s.date,sp.start,sp.finish,s.dentist,s.patient,s.assistant,s.type,d.address
	from schedule s
	join shift_period sp on s.shift_id=sp.id
	join department d on s.department=d.id
	where CAST(s.date AS DATE) = CAST(GETDATE() AS DATE) and accept=1
commit tran
go
create or alter proc locLichHenTheoBN @PatientID int
as
begin tran
	select s.date,sp.start,sp.finish,s.dentist,s.patient,s.assistant,s.type,d.address
	from schedule s
	join shift_period sp on s.shift_id=sp.id
	join department d on s.department=d.id
	where CAST(s.date AS DATE) = CAST(GETDATE() AS DATE) and s.patient=@PatientID and accept=1
commit tran
go
create or alter proc locLichHenTheoBS @dentistUsername char(10)
as
begin tran
	select s.date,sp.start,sp.finish,s.dentist,s.patient,s.assistant,s.type,d.address
	from schedule s
	join shift_period sp on s.shift_id=sp.id
	join department d on s.department=d.id
	where CAST(s.date AS DATE) = CAST(GETDATE() AS DATE) and s.dentist=@dentistUsername and accept=1
commit tran
go
create or alter proc locLichHenTheoPhongKham @DepID int
as
begin tran
	select s.date,sp.start,sp.finish,s.dentist,s.patient,s.assistant,s.type,d.address
	from schedule s
	join shift_period sp on s.shift_id=sp.id
	join department d on s.department=d.id
	where CAST(s.date AS DATE) = CAST(GETDATE() AS DATE) and s.department=@DepID and accept=1
commit tran
go

--select * from quantity_medicine where department=23
--exec themThuocChoKHDT 1,'10019',10,'abc'
--select * from prescription where treatment=1
--exec suaThuocChoKHDT 1,'10019',15,'abc'
--select * from prescription where treatment=1
--exec xoaThuocChoKHDT 1,'10019'
--select * from prescription where treatment=1

--exec xemKHDT 6638
--exec XemHoaDonCuaKH 2961

--exec xemLichHenTrongNgay
--exec locLichHenTheoBN 2276
--exec locLichHenTheoBS 'DEN0000690'
--exec locLichHenTheoPhongKham 49
 