create table mydbhakgwa(
    code char(3) primary key,
    name varchar(30) -- �ִ� 10����. �ѱ��� ��� 1���ڴ� 3����Ʈ
);

create table mydbstudent(
    hakbeon varchar2(10) primary key,
    name varchar2(60),
    age int,
    HakGwaCode char(3), -- �а����̺��� code�� �����ϴ� �ܷ�Ű
    FOREIGN key(HakGwaCode) references mydbhakgwa(code)
);

insert into mydbhakgwa values('001', '�İ�');
insert into mydbhakgwa values('002', '�Ƶ�������');

insert into mydbstudent values('12345A','�̵���',33,'001');
insert into mydbstudent values('12345B','���湮',23,'001');
insert into mydbstudent values('12345C','������',20,'002');
insert into mydbstudent values('12345D','�����',25,'002');
insert into mydbstudent values('12345E','������',27,'002');
insert into mydbstudent values('12345A','�̵���',33,'009'); --�߰��ȵ�

select * from mydbhakgwa;
select * from mydbstudent

