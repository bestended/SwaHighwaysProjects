alter proc drcrud
@DriverId int,
@IdentificationNum nvarchar(50),
@Name nvarchar(50),
@Surname nvarchar(50),
@LicenceDate smalldatetime,
@Age int,
@Phone nvarchar(50),
@mail nvarchar(50),
@type nvarchar(50)
as begin

if(@type='insert')
begin insert into Drivers(IdentificationNum,Name,Surname,LicenceDate,Age,Phone,mail)
values(@IdentificationNum,@Name,@Surname,@LicenceDate,@Age,@Phone,@mail)
end

else if(@type='update')
begin update Drivers
set IdentificationNum=@IdentificationNum,Name=@Name,Surname=@Surname,LicenceDate=@LicenceDate,
Age=@Age,Phone=@Phone,mail=@mail where DriverId=@DriverId
end

else if(@type='delete')
begin delete from Drivers where DriverId=@DriverId
end

end

create proc drListele
as begin
select * from Drivers
end