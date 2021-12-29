var o_cursor refcursor; --o_cursor이라는 refcursor 변수 선언 
exec person_select('이동준',:o_cursor); -- o_cursor에 값저장
print o_cursor; -- o_cursor에 있는 것들 print함

exec add_person(10,'이동준','010-1111-3333');