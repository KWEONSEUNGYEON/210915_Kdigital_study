interface  ANIMAL{
    public static final int DOG = 1;
    int CAT = 2;
}
interface PERSON{
    int MAN = 1;
    int WOMAN = 2;
}

public class Ex01 {
    public static void main(String[] args) {
        who(PERSON.MAN);
//        Who(ANIMAL.DOG);
    }

    private static void who(int man) {
        switch (man) {
            case PERSON.MAN:
                System.out.println("남성손님입니다.");
                break;
            case PERSON.WOMAN:
                System.out.println(("여성손님입니다."));
                break;
        }
    }
}

