create table Employee(
    sabeon number primary key,
    name varchar2(20) not null,
    age int,
    gikgeub varchar2(30)
);

insert into Employee values(200903803, 'lee', 33, 'senior');
insert into Employee values(2021000111, 'park', 19, 'manager');
insert into Employee values(2021000112, 'kim', 77, 'beginner');
insert into Employee values(2021000113, 'choi', 55, 'senior');
insert into Employee values(2021000114, 'Jang', 47, 'manager');

-- 내가 컬럼의 순서를 모르거나, 컬럼의 순서를 명시해주고 싶은 경우
-- 컴럼 = column = 열
insert into Employee(sabeon, name, age, gikgeub) values(200903803, 'lee', 33, 'senior');
-- 일부 값을 몰라서 못 적는 경우
insert into Employee(sabeon, name) values(2021000112, 'kim');

select * from Employee;



update employee set gikgeub='beginner' where age <=30;
update employee set gikgeub='manager' where age >=50;

delete from employee where age>=70;

select * from employee;

select * from employee where gikgeub='senior';

-- 나이 순 정렬 가능
select * from employee order by age; -- 오름차순
select * from employee order by age desc; -- 내림차순

-- 특정 컬럼만 보기
select sabeon, age from employee;

--특정 컬럼에 이름 지정(as 키워드 생략 가능)
select sabeon as "사원번호", age as "나이" from employee;

-- 이름 안에 a 라는 글자가 있는 사람만 조회하기
-- a의 앞글자는 하나도 없거나 1글자 이상이고
-- a의 뒷글자도 하나도 없거나 1글자 이상이다.
-- % : 0글자 이상
select * from employee where name like '%a%';

commit;
-- 커밋을 자동적으로 하게 하고 싶으면
show autocommit; --현재 커밋이 자동으로 되는지 확인해보고
set autocommit on; --off라면 해당 코드 작성하기
