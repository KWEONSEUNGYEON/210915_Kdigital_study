select * from student;
select * from student where age>20;
select * from student where age>20 and age<30;
select * from student where name='���湮' or name='�ǵ���';
-- || <- �̱�ȣ�� mysql������ where������ �������� oracle������ or Ű���常 ����
-- select * from student where name='���湮' || name='�ǵ���';
select * from student where name='��'||'�湮';