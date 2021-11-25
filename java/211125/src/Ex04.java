import java.util.Scanner;

public class Ex04 {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        System.out.println("숫자 입력시 형변환해서 출력>>");
        String line = scan.nextLine();

        int myint = Integer.parseInt(line)+10;

        System.out.println("int 형 = "+myint);

        String myintS = Integer.toString(myint);

        System.out.println("String 형 ="+myintS);
    }
}
