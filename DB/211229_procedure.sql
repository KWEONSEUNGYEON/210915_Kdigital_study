create or replace procedure add_person
(
    mynum in int, --�Ű�����, in Ű����� �Ű������� �ǹ���
    myname varchar2,
    mypn varchar2
)
IS
BEGIN
    insert into simple_address_book values(mynum, myname, mypn);
END add_person;