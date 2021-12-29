select * from orders;
select * from customer;
select * from book;

--unique �Ӽ�
--primary key : unique + not null
--�ֹι�ȣ
--unique : ��ġ�� �ȵǴµ�, null ���� ok
--��ȭ��ȣ

create table simple_address_book(
    num int primary key, -- ����ȣ, ��ġ�� �ȵ�(�������δ���ϱ�)
    name varchar2(30) not null,-- �̸��� ���� ���� ����
    phone_number varchar2(20) unique -- ��ȭ��ȣ�� ���� ����� �ִ�.
);

insert into simple_address_book values(1,'�̵���',null);
insert into simple_address_book values(2,'�ǵ���','010-xxxx-zzzz');
insert into simple_address_book values(3,'�̵���','010-2940-1613');
insert into simple_address_book values(4,'�̰�ȣ','010-2940-1613');
insert into simple_address_book values(5,null,null);
insert into simple_address_book values(6,null,'xxx-xxxx-xxxx');
select * from simple_address_book;

alter table book rename column booname to bookname; -- �̸�����

select * from orders;
select * from book;

--�ֹ���ȣ å�̸�, ���� -> å �̸��� ����
select orderid, book.bookname, orders.saleprice, orders.custid from orders join book on orders.bookid=book.bookid;

--�ֹ���ȣ, ����, saleprice, bookid -> �� �̸��� ����
select orderid, customer.name, saleprice, bookid from orders join customer on orders.custid=customer.custid;

--��ø ���� �� �ᵵ ��
select orders.orderid, book.bookname, orders.saleprice, customer.name FROM  orders, book, customer where orders.custid = customer.custid and orders.bookid=book.bookid order by orderid;

--��ø ���� �Ἥ Ǫ�� �� -> view�� �����Ǳ� ����
--customer ���̺�� �׸��� book�� orders�� join�� ������� �ٽ� ���� join
select orderid, aa.bookname, customer.name, saleprice from 
(select orderid, book.bookname, orders.saleprice, orders.custid from 
orders join book on orders.bookid=book.bookid) aa join customer on 
aa.custid = customer.custid order by orderid;

-- book�� orders�� customer�� join�� ���̺��� join
select orderid, aa.name, book.bookname, saleprice from (select orderid, customer.name, saleprice, bookid from orders join customer on orders.custid=customer.custid) aa join book on aa.bookid = book.bookid order by orderid;
