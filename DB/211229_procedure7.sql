create procedure person_select
(
    myname in varchar2, --�Ű�����
    o_cursor out sys_refcursor --Ŀ���� ��ȯ
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

-- ������ ��ü�� �̸��� ����ϰ� �ֽ��ϴ�.
-- ���ν����� ����ų� ���鶧 �ƿ� create or replace�� �ٿ�����