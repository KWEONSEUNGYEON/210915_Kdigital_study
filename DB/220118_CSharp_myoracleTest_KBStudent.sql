create table MyoracleTest
(
   id int primary key,
   name varchar2(20)
);
select * from myoracletest;
insert into MyoracleTest values(1, 'lee');
insert into MyoracleTest values(2,'park');

commit;


create table KB_STUDENT
(
    hakbeon number primary key,
    name varchar2(100),
    age int,
    gender varchar2(10)
);

commit;

select * from KB_STUDENT