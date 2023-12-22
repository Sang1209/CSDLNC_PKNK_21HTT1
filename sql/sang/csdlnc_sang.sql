use csc12002_21clc10_n10
go
create or alter proc xemThuocCuaKHDT @TreatmentID int
as
begin tran
	select m.id,m.name,p.quantity,p.note,t.state
	from  prescription p join medicine m on p.medicine=m.id join treatment t on p.treatment=t.id
	where p.treatment=@TreatmentID
commit tran
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
if (exists(select * from prescription where treatment=@TreatmentID and medicine=@MedicineID))
begin
	update prescription set quantity=quantity+@amount where treatment=@TreatmentID and medicine=@MedicineID
end
else
begin
	insert into Prescription values(@TreatmentID,@MedicineID,@amount,@note)
end
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
select p.treatment,p.num,p.total,p.given,pm.name as method,p.date,p.payer,p.note 
from (select id,Patient from treatment) t 
join Payment p on t.id=p.Treatment 
join payment_method pm on p.method=pm.id
where t.Patient=@PatientID
commit tran
go
create or alter proc xemLichHenTrongNgay
as
begin tran
	select s.date,s.shift_id,sp.start,sp.finish,s.dentist,s.patient,s.assistant,s.type,d.id,d.address as DepAddress
	from schedule s
	join shift_period sp on s.shift_id=sp.id
	join department d on s.department=d.id
	where CAST(s.date AS DATE) = CAST(GETDATE() AS DATE)
commit tran
go
create or alter proc locLichHenTheoBN @PatientID int
as
begin tran
	select s.date,s.shift_id,sp.start,sp.finish,s.dentist,s.patient,s.assistant,s.type,d.id,d.address as DepAddress
	from schedule s
	join shift_period sp on s.shift_id=sp.id
	join department d on s.department=d.id
	where CAST(s.date AS DATE) = CAST(GETDATE() AS DATE) and s.patient=@PatientID
commit tran
go
--co nen search bang like k nhi :>
create or alter proc locLichHenTheoBS @dentistUsername varchar(10)
as
begin tran
	select s.date,s.shift_id,sp.start,sp.finish,s.dentist,s.patient,s.assistant,s.type,d.id,d.address as DepAddress
	from schedule s
	join shift_period sp on s.shift_id=sp.id
	join department d on s.department=d.id
	where CAST(s.date AS DATE) = CAST(GETDATE() AS DATE) and Cast(s.dentist as varchar(10)) like '%'+@dentistUsername+'%'
commit tran
go
create or alter proc locLichHenTheoPhongKham @DepID int
as
begin tran
	select s.date,s.shift_id,sp.start,sp.finish,s.dentist,s.patient,s.assistant,s.type,d.id,d.address as DepAddress
	from schedule s
	join shift_period sp on s.shift_id=sp.id
	join department d on s.department=d.id
	where CAST(s.date AS DATE) = CAST(GETDATE() AS DATE) and s.department=@DepID
commit tran
go
--select * from quantity_medicine where department=23
--exec themThuocChoKHDT 938,'71185',1,'abc'
--select * from prescription where treatment=938
--exec suaThuocChoKHDT 1,'10019',15,'abc'
--select * from prescription where treatment=1
--exec xoaThuocChoKHDT 938,'77146'
--select * from prescription where treatment=1

--exec xemKHDT 6638
--exec XemHoaDonCuaKH 8461
--select * from account_de
--exec pr_add_schedule '2023-12-22',2,'DEN0000000','DEN0000003',5
--select * from schedule where CAST(date AS DATE) = CAST(GETDATE() AS DATE)
--select * from account_adst
--select * from account_de
--exec xemLichHenTrongNgay
--exec locLichHenTheoBN 2276
--exec locLichHenTheoBS 'DEN0000000'
--exec locLichHenTheoPhongKham 49
--exec xemThuocCuaKHDT 938
 