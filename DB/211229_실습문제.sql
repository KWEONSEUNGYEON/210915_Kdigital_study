create table userTbl(
    userid char(8) primary key,
    username varchar2(10) not null
);

insert into userTbl values('KHD','��ȣ��');
insert into userTbl values('KJD','������');
insert into userTbl values('KKJ','�豹��');
insert into userTbl values('KYM','��븸');
insert into userTbl values('LHJ','������');
insert into userTbl values('LKK','�̰��');
insert into userTbl values('NHS','����');
insert into userTbl values('PSH','�ڼ�ȫ');
insert into userTbl values('SDY','�ŵ���');
insert into userTbl values('YJS','���缮');

select * from userTbl;

create sequence myseq3 start with 1 increment by 1 maxvalue 100 cycle nocache;
-- create sequence myseq3 increment by 1 maxvalue 100 minvalue 1 cycle nocache;
-- drop sequence myseq3;

create table buyTbl(
    num int primary key,
    userId char(8),
    prodName varchar(50) not null,
    price int not null,
    amount int not null,
    FOREIGN key(userId) references userTbl(userId)
);
-- alter table buytbl add CONSTRAINT fk_buy FOREIGN key (userid) references usertbl(userid);

insert into buyTbl values(myseq3.nextval,'KHD','�ȭ',30,2);
insert into buyTbl values(myseq3.nextval,'KHD','��Ʈ��',1000,1);
insert into buyTbl values(myseq3.nextval,'KYM','�����',200,1);
insert into buyTbl values(myseq3.nextval,'PSH','�����',200,5);
insert into buyTbl values(myseq3.nextval,'KHD','û����',50,3);
insert into buyTbl values(myseq3.nextval,'PSH','�޸�',80,10);
insert into buyTbl values(myseq3.nextval,'KJD','å',15,5);
insert into buyTbl values(myseq3.nextval,'LHJ','å',15,2);
insert into buyTbl values(myseq3.nextval,'LHJ','û����',50,1);
insert into buyTbl values(myseq3.nextval,'PSH','�ȭ',30,2);
insert into buyTbl values(myseq3.nextval,'LHJ','å',15,1);
insert into buyTbl values(myseq3.nextval,'PSH','�ȭ',30,2);

select * from userTbl;
select * from buyTbl;

--1������
select username ����ڸ�, prodname ��ǰ��, price ����, amount ����, (price*amount) as �Ѱ��� from buytbl join usertbl on buytbl.userid=usertbl.userid;

--2������
select username ����ڸ�, sum(price*amount) as �Ѱ��� from buytbl join usertbl on buytbl.userid=usertbl.userid group by username;

--3������
select username ����ڸ�, sum(price*amount) as �Ѱ��� from buytbl join usertbl on buytbl.userid=usertbl.userid group by username having sum(price*amount)>1000;