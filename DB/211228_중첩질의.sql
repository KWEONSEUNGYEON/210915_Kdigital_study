select * from book order by publisher;

--���ǻ纰 ����
select sum(price),publisher from book group by publisher;
--���ǻ�� å�� ��
--count(*):group by�� ������ �� ���� �׷����� ���̴� ���� ����
-- �� : �½����� �׷��� 3���̹Ƿ� 3�� ���´�.
select count(*),publisher from book group by publisher order by count(*) desc;
--å���� ���� ����
select sum(price) �Ѱ��� from book;

-- å�� 2�� �̻��� ���ǻ縸 ���
select publisher from book group by publisher having count(*)>1;

select * from book;

--���� ��� ������?
select max(price) from book;

--���� ��� å��?
--��ø ����
select * from book where price = (select max(price) from book);
select * from book where price = (select min(price) from book);
