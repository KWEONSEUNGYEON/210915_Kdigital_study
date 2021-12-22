select * from student;
select * from hakgwa;
-- 학과 테이블을 먼저 채워야지만 학생들을 등록할 수 있음
insert into hakgwa values('001','컴공');
insert into hakgwa values('002','전자공학');
insert into hakgwa values('003','심리학');
insert into hakgwa values('004','아동가족학');
insert into hakgwa (name,code) values('도박학과','777');
insert into hakgwa (name,code) values('아마게돈과','666');

select * from dual;
select lengthb('장') from dual; -- 바이트크기 체크
select lengthb('a') from dual;
select lengthb('1') from dual;
select length('장') from dual; -- 글자 길이 체크
insert into student values('12345','001','류경문');
insert into student values('22222','007','제임스본드');

insert into hakgwa values('007','카지노로얄과');

select * from student;

insert into student values('11111','002','권용규');
insert into student values('88888','001','이동준');

select * from student,hakgwa;-- 아무의미없는코드!
select * from student s, hakgwa h where s.hakgwa_code=h.code;
select hakbeon, s.name, h.name from student s, hakgwa h where s.hakgwa_code=h.code;

select * from student, hakgwa where student.hakgwa_code=hakgwa.code;
select hakbeon, student.name, hakgwa.name from student, hakgwa where student.hakgwa_code=hakgwa.code;

insert into student values('21432','001','권승연');
insert into student values('22342','002','권승연');
insert into student values('22362','003','권소영');
delete from student where hakbeon='권소영';
insert into student values('17454','004','정세윤');
insert into student values('17458','777','김홍주');
insert into student values('97458','666','이승희');

select * from student;

-- 또 다른 조인 방법(ANSI 표준)
-- ANSI SQL = 미국 표준 협회에서 표준화한 SQL문

-- inner join 혹은 join : 양쪽 테이블에서 매칭이 되는 것만 나타냄
-- 즉 003 심리학과처럼 소속된 학생이 없는 과는 안나타남
select * from student join hakgwa on student.hakgwa_code=hakgwa.code;
select * from student inner join hakgwa on student.hakgwa_code=hakgwa.code;

--left join : 왼쪽 테이블에 있는 건 전부 다 나타내기
select * from student left join hakgwa on student.hakgwa_code=hakgwa.code;

--right join
select * from student right join hakgwa on student.hakgwa_code=hakgwa.code;

--outer join
--Full join, mysql에서는 별도의 구현이 필요한 것
select * from student full join hakgwa on student.hakgwa_code=hakgwa.code;

--self join


