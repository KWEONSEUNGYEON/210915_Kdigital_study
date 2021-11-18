import java.util.InputMismatchException;
import java.util.Scanner;

public class Ex03 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        try {
            System.out.print("a = ? ");
            int a = scanner.nextInt();
            System.out.print("b = ? ");
            int b = scanner.nextInt();

            System.out.print("a/b = ?" + a / b);
            System.out.println("완료...");
        }
        catch (ArithmeticException ae) {
            ae.printStackTrace();
            System.out.println("나누기 예외발생...");
        }
        catch (InputMismatchException ime) {
            ime.printStackTrace();
            System.out.println("문자열 넣기 예외발생...");
        }
//        catch(Exception ae) {
//            ae.printStackTrace();
//            System.out.println("모든예외...");
//        }
        System.out.println("bye bye");
    }
}
