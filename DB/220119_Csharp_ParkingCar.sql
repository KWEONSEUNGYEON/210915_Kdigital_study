create table ParkingCar
(
    ParkingSpot number primary key,
    CarNumber varchar2(30),
    DriverName varchar2(30),
    PhoneNumber varchar2(30),
    ParkingTime Date default sysdate
);
/*
����->ȯ�漳��->�����ͺ��̽�->NLS ��¥������ yyyy-MM-DD HH24:MI:SS
*/

insert into ParkingCar values(1,'30��1234','�ǽ¿�','010-7708-6396',sysdate);

select * from ParkingCar;

delete from ParkingCar;

commit;