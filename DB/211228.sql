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

-- ���� �÷��� ������ �𸣰ų�, �÷��� ������ ������ְ� ���� ���
-- �ķ� = column = ��
insert into Employee(sabeon, name, age, gikgeub) values(200903803, 'lee', 33, 'senior');
-- �Ϻ� ���� ���� �� ���� ���
insert into Employee(sabeon, name) values(2021000112, 'kim');

select * from Employee;



update employee set gikgeub='beginner' where age <=30;
update employee set gikgeub='manager' where age >=50;

delete from employee where age>=70;

select * from employee;

select * from employee where gikgeub='senior';

-- ���� �� ���� ����
select * from employee order by age; -- ��������
select * from employee order by age desc; -- ��������

-- Ư�� �÷��� ����
select sabeon, age from employee;

--Ư�� �÷��� �̸� ����(as Ű���� ���� ����)
select sabeon as "�����ȣ", age as "����" from employee;

-- �̸� �ȿ� a ��� ���ڰ� �ִ� ����� ��ȸ�ϱ�
-- a�� �ձ��ڴ� �ϳ��� ���ų� 1���� �̻��̰�
-- a�� �ޱ��ڵ� �ϳ��� ���ų� 1���� �̻��̴�.
-- % : 0���� �̻�
select * from employee where name like '%a%';

commit;
-- Ŀ���� �ڵ������� �ϰ� �ϰ� ������
show autocommit; --���� Ŀ���� �ڵ����� �Ǵ��� Ȯ���غ���
set autocommit on; --off��� �ش� �ڵ� �ۼ��ϱ�
