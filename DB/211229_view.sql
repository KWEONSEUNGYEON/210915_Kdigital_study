-- view �������̺�
-- ���� �����ϴ� �� �ƴѵ�, ������ �������̰ų� ������ �������� �� select ������� �̸� �����α�

create or replace view mytestview as select * from orders;

select * from mytestview;

--or replace�� ��������
-- �̰� ���ִ� ������ �̸��� ��ġ�� view�� ����� �Ǹ� ����� ����� ����
-- ���ɷ� ��� ������ ���ٸ� or replace ��������
create view expensive_book as
select * from book where price>10000;

select * from expensive_book;
