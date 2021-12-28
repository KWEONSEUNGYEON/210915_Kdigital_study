create table mydbhakgwa(
    code char(3) primary key,
    name varchar(30) -- 최대 10글자. 한글일 경우 1글자당 3바이트
);

create table mydbstudent(
    hakbeon varchar2(10) primary key,
    name varchar2(60),
    age int,
    HakGwaCode char(3), -- 학과테이블의 code를 참조하는 외래키
    FOREIGN key(HakGwaCode) references mydbhakgwa(code)
);

insert into mydbhakgwa values('001', '컴공');
insert into mydbhakgwa values('002', '아동가족학');

insert into mydbstudent values('12345A','이동준',33,'001');
insert into mydbstudent values('12345B','류경문',23,'001');
insert into mydbstudent values('12345C','윤혜림',20,'002');
insert into mydbstudent values('12345D','장상은',25,'002');
insert into mydbstudent values('12345E','구혜진',27,'002');
insert into mydbstudent values('12345A','이동준',33,'009'); --추가안됨

select * from mydbhakgwa;
select * from mydbstudent

