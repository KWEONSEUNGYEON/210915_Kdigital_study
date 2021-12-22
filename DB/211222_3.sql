create table student
(
    name varchar2(20),
    age int,
    hakbeon varchar2(20) primary key
);

create table teacher
(
    name varchar2(20),
    age int,
    sabeon varchar2(20) primary key
);

insert into student values('±Ç¿ë±Ô',15,'20903');
insert into student values('·ù°æ¹®',25,'19703');
insert into student values('±Ç½Â¿¬',35,'18809');
insert into student values('±è¹Î¾Æ',20,'22103');
insert into student values('±Çµµ±Õ',22,'21809');

select * from student;

insert into teacher values('ÀÌ³ª°â',20,'2021090101');
insert into teacher values('ÀÌµ¿ÁØ',30,'2011080105');
insert into teacher values('¹ÚÈ£¹ü',40,'2001030301');
insert into teacher values('¹Ú¸íÈ¸',25,'2020101011');
insert into teacher values('±èÈ«±Ù',30,'1999030207');

select * from teacher;

delete from student where name='±Ç¿ë±Ô';
select * from student;

select * from teacher where name='ÀÌ³ª°â';

select * from teacher where name='¹ÚÈ£¹ü';
update teacher set age=25 where name='¹ÚÈ£¹ü';
select * from teacher;

commit;

select * from teacher where sabeon='2011080105';
update teacher set name='ÀÌÁÖ¹Î';
rollback;
update teacher set name='ÀÌÁÖ¹Î' where sabeon='2011080105';
select * from teacher;
select * from student;
commit;
