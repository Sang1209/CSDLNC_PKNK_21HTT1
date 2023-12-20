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



exec fix1
exec fix2
exec fix3
exec fix4