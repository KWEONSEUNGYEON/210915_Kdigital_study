import java.util.Scanner;

public class Pr01 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

//        1번
        System.out.println("이름을 성과 이름을 띄워서 영어로 입력");
        String first = scan.next();
        String second = scan.next();

        System.out.println("성 "+first.substring(0,4));
        System.out.println("이름 "+second.substring(0));
        System.out.println();

//        2번
        System.out.println("입력");
        String name = scan.next();


        System.out.println("출력");
        System.out.println("파일명 "+name.substring(0,5));
        System.out.println("확장자 "+name.substring(6));

//        3번
        System.out.println("1. 더하기 2. 빼기 3. 나누기 4. 곱하기 5. 나머지 6. 종료");
        System.out.println("무엇을 하시겠습니까?");
        String

    }
}
