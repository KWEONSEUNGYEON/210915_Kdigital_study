create procedure person_select
(
    myname in varchar2, --매개변수
    o_cursor out sys_refcursor --커서를 반환
)
IS
BEGIN
    open o_cursor
    for
        select num,name,phone_number from simple_address_book where name=myname;
exception
    when others then
        dbms_output.put_line('sql error : '||SQLERRM);
    end person_select;    

-- 기존의 객체가 이름을 사용하고 있습니다.
-- 프로시저를 지우거나 만들때 아예 create or replace를 붙여버림