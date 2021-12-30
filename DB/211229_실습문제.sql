create table userTbl(
    userid char(8) primary key,
    username varchar2(10) not null
);

insert into userTbl values('KHD','강호동');
insert into userTbl values('KJD','김제동');
insert into userTbl values('KKJ','김국진');
insert into userTbl values('KYM','김용만');
insert into userTbl values('LHJ','이휘재');
insert into userTbl values('LKK','이경규');
insert into userTbl values('NHS','남희석');
insert into userTbl values('PSH','박수홍');
insert into userTbl values('SDY','신동엽');
insert into userTbl values('YJS','유재석');

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

insert into buyTbl values(myseq3.nextval,'KHD','운동화',30,2);
insert into buyTbl values(myseq3.nextval,'KHD','노트북',1000,1);
insert into buyTbl values(myseq3.nextval,'KYM','모니터',200,1);
insert into buyTbl values(myseq3.nextval,'PSH','모니터',200,5);
insert into buyTbl values(myseq3.nextval,'KHD','청바지',50,3);
insert into buyTbl values(myseq3.nextval,'PSH','메모리',80,10);
insert into buyTbl values(myseq3.nextval,'KJD','책',15,5);
insert into buyTbl values(myseq3.nextval,'LHJ','책',15,2);
insert into buyTbl values(myseq3.nextval,'LHJ','청바지',50,1);
insert into buyTbl values(myseq3.nextval,'PSH','운동화',30,2);
insert into buyTbl values(myseq3.nextval,'LHJ','책',15,1);
insert into buyTbl values(myseq3.nextval,'PSH','운동화',30,2);

select * from userTbl;
select * from buyTbl;

--1번문제
select username 사용자명, prodname 제품명, price 가격, amount 수량, (price*amount) as 총가격 from buytbl join usertbl on buytbl.userid=usertbl.userid;

--2번문제
select username 사용자명, sum(price*amount) as 총가격 from buytbl join usertbl on buytbl.userid=usertbl.userid group by username;

--3번문제
select username 사용자명, sum(price*amount) as 총가격 from buytbl join usertbl on buytbl.userid=usertbl.userid group by username having sum(price*amount)>1000;