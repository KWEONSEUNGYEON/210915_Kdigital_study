select * from mytable;

insert into mytable (id) values(66);
insert into mytable values('������',55);

commit;
select * from mytable;
-- ���̺� �ִ� ��� ���� �����
delete from mytable;
rollback;

-- ���� ����(���������)
-- rollback �� ��
drop table mytable;