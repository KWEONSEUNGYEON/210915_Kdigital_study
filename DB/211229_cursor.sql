var o_cursor refcursor; --o_cursor�̶�� refcursor ���� ���� 
exec person_select('�̵���',:o_cursor); -- o_cursor�� ������
print o_cursor; -- o_cursor�� �ִ� �͵� print��

exec add_person(10,'�̵���','010-1111-3333');