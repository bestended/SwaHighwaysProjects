create proc vecrud
@CarId int,
@Plate nvarchar(8),
@Brand nvarchar(50),
@Model nvarchar(50),
@Color nvarchar(50),
@DriverId int,
@BridgeId int,
@type nvarchar(50)
as begin


if(@type='insert')
begin insert into Vehicles(Plate,Brand,Model,Color,DriverId,BridgeId)
values(@Plate,@Brand,@Model,@Color,@DriverId,@BridgeId)
end

else if(@type='update')
begin update Vehicles
set Plate=@Plate,Brand=@Brand,Model=@Model,Color=@Color,DriverId=@DriverId,BridgeId=@BridgeId
where CarId=@CarId
end

else if(@type='delete')
begin delete from Vehicles where CarId=@CarId
end

end

create proc veListele
as begin 
select * from Vehicles
end