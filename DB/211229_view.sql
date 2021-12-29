-- view 가상테이블
-- 실제 존재하는 건 아닌데, 복잡한 쿼리문이거나 복잡한 쿼리문에 들어갈 select 결과물을 미리 만들어두기

create or replace view mytestview as select * from orders;

select * from mytestview;

--or replace는 생략가능
-- 이걸 써주는 이유는 이름이 겹치는 view를 만들게 되면 새결로 덮어쓰기 위함
-- 새걸로 덮어쓸 생각이 없다면 or replace 생략가능
create view expensive_book as
select * from book where price>10000;

select * from expensive_book;
