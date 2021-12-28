-- 트랜젝션 : insert, update, delete 와 값이 테이블에 변화를 주는 '명령' 단위
-- 길이는 cm 무게는 g 이런 단위를 쓰듯이, 쓰는 단위

-- 시간 표시
-- 데이터에선 시간을 표시하는 게 매우중요
-- 예를 들자면 연장근무관리 시스템
-- 연장근무를 했다는 메시지를 실제 연장근무한 시점에 보냈느냐
-- 아니면 거짓으로 연장근무했다고 보냈느냐
-- 혹은 연장근무했다고 메시지 보냈는데, 그게 반영이 안 됐느냐..
-- 이런 것들 알려면 데이터가 "언제" 들어갔는지를 알아야 함

insert into mytimetable (column1) values(sequence1.nextval);
select * from mytimetable;