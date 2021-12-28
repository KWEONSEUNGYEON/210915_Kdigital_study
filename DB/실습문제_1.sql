create table song(
id int primary key,
title varchar2(40) not null,
price int
);

create table singer (
id int primary key,
name varchar2(30),
hit_song_id int,
foreign key(hit_song_id) references song(id) -- 외래키 추가
);


--가수부터 넣은 순 있는데 hitsong값을 null로 지정해야 함
-- insert into singer values(1, '브레이브걸스', null);

-- 노래부터 집어넣어야 한다.
insert into song values(1,'롤린',10000);
insert into song values(2,'Gee',9000);
insert into song values(3,'Next Level',8000);
select * from song;

insert into singer values(1, '브레이브걸스',1);
insert into singer values(2, '소녀시대',2);
select * from singer;


-- join
-- ANSI SQL(표준 스타일)
-- 우리가 아는 일반적 조인(inner join)
select * from singer, song where singer.hit_song_id=song.id;

-- 히트송이 존재하는 가수만 출력함
select name, title from singer join song on singer.hit_song_id=song.id;

-- 히트송이 없는 가수들도 출력됨
select name, title from singer left join song on singer.hit_song_id=song.id;

-- 가수가 없는 노래도 다 출력됨. 즉 song에 있는 게 다 출력됨
select name, title from singer right join song on singer.hit_song_id=song.id;

-- full=outer(left,right 합친 것)
select name, title from singer full join song on singer.hit_song_id=song.id;

select singer.name, song.title from singer, song where singer.hit_song_id=song.id;
