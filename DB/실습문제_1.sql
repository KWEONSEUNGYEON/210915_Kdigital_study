select * from song;
insert into song values(1,'롤린',10000);
insert into song values(2,'Gee',9000);
insert into song values(3,'Next Level',8000);

select * from singer;
insert into singer values(1, '브레이브걸스',1);
insert into singer values(2, '소녀시대',2);

select * from singer, song where singer.hit_song_id=song.id;

select * from singer join song on singer.hit_song_id=song.id;

select * from singer left join song on singer.hit_song_id=song.id;

select * from singer right join song on singer.hit_song_id=song.id;

select * from singer full join song on singer.hit_song_id=song.id;

select singer.name, song.title from singer, song where singer.hit_song_id=song.id;
