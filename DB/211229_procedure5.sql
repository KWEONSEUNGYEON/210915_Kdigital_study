create PROCEDURE update_person
(
    mynum in int, --�̸��� �ٲ� �л��� ��ȣ
    changeName in varchar2 -- ���� ������ ������ �̸�
)
IS
    tempvar varchar2(20):='�л�'; -- tempvar ������ �л��� ����
BEGIN
    tempvar := changeName || tempvar; --���� �ٲ� �̸� +�л� ex)�̵����л�
    update simple_address_book set name=tempvar
    where num=mynum;
END update_person;