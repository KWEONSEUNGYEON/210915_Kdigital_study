select orderid, aa.bookname, customer.name, saleprice from 
aa join customer on 
aa.custid = customer.custid order by orderid;

create view aa as select orderid, book.bookname, orders.saleprice, orders.custid from 
orders join book on orders.bookid=book.bookid;