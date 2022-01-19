create table ParkingCar
(
    ParkingSpot number primary key,
    CarNumber varchar2(30),
    DriverName varchar2(30),
    PhoneNumber varchar2(30),
    ParkingTime Date default sysdate
);
/*
도구->환경설정->데이터베이스->NLS 날짜형식을 yyyy-MM-DD HH24:MI:SS
*/

insert into ParkingCar values(1,'30가1234','권승연','010-7708-6396',sysdate);

select * from ParkingCar;

delete from ParkingCar;

commit;