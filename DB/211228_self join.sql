select * from hakgwa;
select * from student;

-- join 형태
select hakgwa.name 학과명, hakbeon 학번, student.name 이름 from hakgwa, student where hakgwa.code=student.hakgwa_code;



-- 실습문제_2
create table samsungpeople(
    id int primary key,
    name varchar2(20),
    boss_id int
);

insert into samsungpeople values(1, '이건희', 1);
insert into samsungpeople values(2, '홍라희', 2);
insert into samsungpeople values(3, '이부진', 1);
insert into samsungpeople values(4, '이재용', 1);
insert into samsungpeople values(5, '신라호텔', 3);
insert into samsungpeople values(6, '삼성전자', 4);
insert into samsungpeople values(7, '수원삼성', 4);
insert into samsungpeople values(8, '삼성라이온즈', 4);

select * from samsungpeople;

-- self join을 하려면 테이블에 이름을 붙여야함
select aa.name boss, bb.name name from samsungpeople aa join samsungpeople bb on aa.id=bb.boss_id;