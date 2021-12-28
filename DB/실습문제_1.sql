create table song(
id int primary key,
title varchar2(40) not null,
price int
);

create table singer (
id int primary key,
name varchar2(30),
hit_song_id int,
foreign key(hit_song_id) references song(id) -- �ܷ�Ű �߰�
);


--�������� ���� �� �ִµ� hitsong���� null�� �����ؾ� ��
-- insert into singer values(1, '�극�̺�ɽ�', null);

-- �뷡���� ����־�� �Ѵ�.
insert into song values(1,'�Ѹ�',10000);
insert into song values(2,'Gee',9000);
insert into song values(3,'Next Level',8000);
select * from song;

insert into singer values(1, '�극�̺�ɽ�',1);
insert into singer values(2, '�ҳ�ô�',2);
select * from singer;


-- join
-- ANSI SQL(ǥ�� ��Ÿ��)
-- �츮�� �ƴ� �Ϲ��� ����(inner join)
select * from singer, song where singer.hit_song_id=song.id;

-- ��Ʈ���� �����ϴ� ������ �����
select name, title from singer join song on singer.hit_song_id=song.id;

-- ��Ʈ���� ���� �����鵵 ��µ�
select name, title from singer left join song on singer.hit_song_id=song.id;

-- ������ ���� �뷡�� �� ��µ�. �� song�� �ִ� �� �� ��µ�
select name, title from singer right join song on singer.hit_song_id=song.id;

-- full=outer(left,right ��ģ ��)
select name, title from singer full join song on singer.hit_song_id=song.id;

select singer.name, song.title from singer, song where singer.hit_song_id=song.id;
