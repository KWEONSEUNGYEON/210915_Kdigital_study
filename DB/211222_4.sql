select * from student;
select * from student where age>20;
select * from student where age>20 and age<30;
select * from student where name='류경문' or name='권도균';
-- || <- 이기호가 mysql에서는 where에서도 쓰이지만 oracle에서는 or 키워드만 쓰임
-- select * from student where name='류경문' || name='권도균';
select * from student where name='류'||'경문';