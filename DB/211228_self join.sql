select * from hakgwa;
select * from student;

-- join ����
select hakgwa.name �а���, hakbeon �й�, student.name �̸� from hakgwa, student where hakgwa.code=student.hakgwa_code;



-- �ǽ�����_2
create table samsungpeople(
    id int primary key,
    name varchar2(20),
    boss_id int
);

insert into samsungpeople values(1, '�̰���', 1);
insert into samsungpeople values(2, 'ȫ����', 2);
insert into samsungpeople values(3, '�̺���', 1);
insert into samsungpeople values(4, '�����', 1);
insert into samsungpeople values(5, '�Ŷ�ȣ��', 3);
insert into samsungpeople values(6, '�Ｚ����', 4);
insert into samsungpeople values(7, '�����Ｚ', 4);
insert into samsungpeople values(8, '�Ｚ���̿���', 4);

select * from samsungpeople;

-- self join�� �Ϸ��� ���̺� �̸��� �ٿ�����
select aa.name boss, bb.name name from samsungpeople aa join samsungpeople bb on aa.id=bb.boss_id;