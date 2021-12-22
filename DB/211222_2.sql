select * from mytable;

insert into mytable (id) values(66);
insert into mytable values('윤혜림',55);

commit;
select * from mytable;
-- 테이블에 있는 모든 내용 지우기
delete from mytable;
rollback;

-- 완전 삭제(휴지통비우기)
-- rollback 안 됨
drop table mytable;