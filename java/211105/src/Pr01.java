import java.util.Scanner;

public class Pr01 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("이름을 성과 이름을 띄워서 영어로 입력");
        String name = scan.next();

        System.out.println("성 "+name.substring(0,4));
        System.out.println("이름 "+name.substring(5));

    }

}
