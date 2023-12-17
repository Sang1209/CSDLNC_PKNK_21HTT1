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



exec fix1
exec fix2