create table StudyRoom
(
    SeatSpot number primary key,
    RegisName varchar2(30),
    PhoneNumber varchar2(30),
    RegisMonth number,
    RegisTime Date default sysdate,
    ExpiryTime number
);

commit;