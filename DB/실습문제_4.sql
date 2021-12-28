create table mykbmajor(
    name varchar2(30) not null,
    code char(3) primary key,
    regDate timestamp default sysdate
);

insert into mykbmajor(name, code) values('�����������','001');
select * from mykbmajor;

create table mykbstudent(
    name varchar2(30),
    age int,
    hakbeon char(10),
    hakgwa_code char(3),
    regDate timestamp default sysdate
);

--�Ǽ��� ���̺� ���� �� �ܷ�Ű �߰��� ���ߴٸ�?!
--alter table�� ���̺��� ������ �� �ַ� ���̴� Ű����
--�������Ǹ�(fk_mykbstu) ũ�� �߿����� ������ �ߺ��Ǹ� �ȵ�
alter table mykbstudent add CONSTRAINT fk_mykbstu FOREIGN kEY(hakgwa_code) REFERENCES mykbmajor(code);

insert into mykbstudent (name,age,hakbeon,hakgwa_code) values('�̵���',33,'123A','001');

insert into mykbmajor(name, code) values('���ڰ�','002');
select * from mykbmajor;

insert into mykbstudent (name,age,hakbeon,hakgwa_code) values('������',33,'123B','002');
insert into mykbstudent (name,age,hakbeon,hakgwa_code) values('�̺���',33,'123C','001');
select * from mykbstudent;

-- mykbstudent -> a�� ġȯ
-- mykbmajor -> b�� ġȯ
select a.name, hakbeon, b.name from mykbstudent a join mykbmajor b on a.hakgwa_code=b.code;

select a.name, hakbeon, b.name from mykbstudent a join mykbmajor b on a.hakgwa_code=b.code where b.code='001';
select a.name, hakbeon, b.name from mykbstudent a join mykbmajor b on a.hakgwa_code=b.code where b.name='�����������';

