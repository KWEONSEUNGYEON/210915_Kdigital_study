select * from student;
select * from hakgwa;
-- �а� ���̺��� ���� ä�������� �л����� ����� �� ����
insert into hakgwa values('001','�İ�');
insert into hakgwa values('002','���ڰ���');
insert into hakgwa values('003','�ɸ���');
insert into hakgwa values('004','�Ƶ�������');
insert into hakgwa (name,code) values('�����а�','777');
insert into hakgwa (name,code) values('�Ƹ��Ե���','666');

select * from dual;
select lengthb('��') from dual; -- ����Ʈũ�� üũ
select lengthb('a') from dual;
select lengthb('1') from dual;
select length('��') from dual; -- ���� ���� üũ
insert into student values('12345','001','���湮');
insert into student values('22222','007','���ӽ�����');

insert into hakgwa values('007','ī����ξ��');

select * from student;

insert into student values('11111','002','�ǿ��');
insert into student values('88888','001','�̵���');

select * from student,hakgwa;-- �ƹ��ǹ̾����ڵ�!
select * from student s, hakgwa h where s.hakgwa_code=h.code;
select hakbeon, s.name, h.name from student s, hakgwa h where s.hakgwa_code=h.code;

select * from student, hakgwa where student.hakgwa_code=hakgwa.code;
select hakbeon, student.name, hakgwa.name from student, hakgwa where student.hakgwa_code=hakgwa.code;

insert into student values('21432','001','�ǽ¿�');
insert into student values('22342','002','�ǽ¿�');
insert into student values('22362','003','�Ǽҿ�');
delete from student where hakbeon='�Ǽҿ�';
insert into student values('17454','004','������');
insert into student values('17458','777','��ȫ��');
insert into student values('97458','666','�̽���');

select * from student;

-- �� �ٸ� ���� ���(ANSI ǥ��)
-- ANSI SQL = �̱� ǥ�� ��ȸ���� ǥ��ȭ�� SQL��

-- inner join Ȥ�� join : ���� ���̺��� ��Ī�� �Ǵ� �͸� ��Ÿ��
-- �� 003 �ɸ��а�ó�� �Ҽӵ� �л��� ���� ���� �ȳ�Ÿ��
select * from student join hakgwa on student.hakgwa_code=hakgwa.code;
select * from student inner join hakgwa on student.hakgwa_code=hakgwa.code;

--left join : ���� ���̺� �ִ� �� ���� �� ��Ÿ����
select * from student left join hakgwa on student.hakgwa_code=hakgwa.code;

--right join
select * from student right join hakgwa on student.hakgwa_code=hakgwa.code;

--outer join
--Full join, mysql������ ������ ������ �ʿ��� ��
select * from student full join hakgwa on student.hakgwa_code=hakgwa.code;

--self join


