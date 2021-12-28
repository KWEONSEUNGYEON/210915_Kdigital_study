create table Book(
    bookid int PRIMARY KEY,
    bookname varchar2(40),
    publisher varchar2(40),
    price int
);

create table Customer(
    custid int primary key,
    name varchar2(40),
    address varchar2(50),
    phone varchar2(20)
);

insert into book values(1,'�౸�� ����','�½�����',7000);
insert into book values(2,'�౸�ƴ� ����','������',13000);
insert into book values(3,'�౸�� ����','���ѹ̵��',22000);
insert into book values(4,'���� ���̺�','���ѹ̵��',35000);
insert into book values(5,'�ǰ� ����','�½�����',8000);
insert into book values(6,'���� �ܰ躰���','�½�����',6000);
insert into book values(7,'�߱��� �߾�','�̻�̵��',20000);
insert into book values(8,'�߱��� ��Ź��','�̻�̵��',13000);
insert into book values(9,'�ø��� �̾߱�','�Ｚ��',7500);
insert into book values(10,'Olympic Champions','Pearson',13000);
select * from book;

--(����) unique ��� �Ӽ��� ���� �ߺ��� �� �ǰ� �� �� ����
--pk�� �ٸ����� uq�� null���� �����
--pk = not null + unique
insert into customer values(1,'������','���� ��ü��Ÿ','000-5000-0001');
insert into customer values(2,'�迬��','���ѹα� ����','000-6000-0001');
insert into customer values(3,'��̶�','���ѹα� ������','000-7000-0001');
insert into customer values(4,'�߽ż�','�̱� Ŭ������','000-8000-0001');
insert into customer values(5,'�ڼ���','���ѹα� ����',null);

create table Orders(
    orderid int primary key,
    custid int,
    bookid int,
    saleprice int,
    orderdate date default sysdate,
    FOREIGN key (custid) REFERENCES customer(custid),
    FOREIGN key (bookid) REFERENCES book(bookid)
);

insert into Orders(orderid,custid,bookid) values(1,1,1);
select*from orders;

insert into Orders(orderid,custid,bookid) values(2,1,1);
insert into Orders(orderid,custid,bookid) values(3,2,5);
insert into Orders(orderid,custid,bookid) values(4,3,6);
insert into Orders(orderid,custid,bookid) values(5,4,7);
insert into Orders(orderid,custid,bookid) values(6,1,2);
insert into Orders(orderid,custid,bookid) values(7,4,8);
insert into Orders(orderid,custid,bookid) values(8,3,10);
insert into Orders(orderid,custid,bookid) values(9,2,10);
insert into Orders(orderid,custid,bookid) values(10,3,8);

--order���̺��� fk�� 2����� ��! �� bookid�� book���� �����ϰ�, custid�� customer���� ������!

--��ø ����(=����)
-- ���ӹ� �ȿ� �� �ٸ� �������� �ִ� ��
update Orders set saleprice = (select price from book where bookid=1) where bookid=1;
update Orders set saleprice = (select price from book where bookid=2) where bookid=2;
update Orders set saleprice = (select price from book where bookid=3) where bookid=3;
update Orders set saleprice = (select price from book where bookid=4) where bookid=4;
update Orders set saleprice = (select price from book where bookid=5) where bookid=5;
update Orders set saleprice = (select price from book where bookid=6) where bookid=6;
update Orders set saleprice = (select price from book where bookid=7) where bookid=7;
update Orders set saleprice = (select price from book where bookid=8) where bookid=8;
update Orders set saleprice = (select price from book where bookid=9) where bookid=9;
update Orders set saleprice = (select price from book where bookid=10) where bookid=10;
