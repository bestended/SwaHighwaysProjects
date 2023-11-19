create proc mwcrud
@MotorwayId int,
@Distance int,
@NumberOfLanes int,
@NumberOfSigns int,
@NumberOfTollGate int,
@type nvarchar(50)
as begin

if(@type='insert')
begin insert into Motorway(Distance,NumberOfLanes,NumberOfSigns,NumberOfTollGate)
values(@Distance,@NumberOfLanes,@NumberOfSigns,@NumberOfTollGate)
end

else if(@type='update')
begin update Motorway
set Distance=@Distance,NumberOfLanes=@NumberOfLanes,NumberOfSigns=@NumberOfSigns,
NumberOfTollGate=@NumberOfTollGate where MotorwayId=@MotorwayId
end


else if(@type='delete')
begin delete from Motorway where MotorwayId=@MotorwayId
end

end

create proc mwListele
as begin select * from Motorway
end