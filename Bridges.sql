
create proc brcrud
@BridgeId int,
@BridgeName nvarchar(50),
@DatetimeOfEntry datetime,
@ReleaseDatetime datetime,
@Toll money,
@EntranceLocation nvarchar(50),
@ExitLocation nvarchar(50),
@MotorwayId int,
@type nvarchar(50)
as begin
if(@type='insert')
begin insert into Bridges(BridgeName,DatetimeOfEntry,ReleaseDatetime,Toll,EntranceLocation,
ExitLocation,MotorwayId)
values(@BridgeName,@DatetimeOfEntry,@ReleaseDatetime,@Toll,@EntranceLocation,@ExitLocation,
@MotorwayId)
end

else if(@type='update')
begin update Bridges
set BridgeName=@BridgeName,DatetimeOfEntry=@DatetimeOfEntry,ReleaseDatetime=@ReleaseDatetime,
Toll=@Toll,EntranceLocation=@EntranceLocation,ExitLocation=@ExitLocation,MotorwayId=@MotorwayId
where BridgeId=@BridgeId
end

else if(@type='delete')
begin delete from Bridges
where BridgeId=@BridgeId
end

end

create proc brListele
as begin
select * from Bridges
end
















