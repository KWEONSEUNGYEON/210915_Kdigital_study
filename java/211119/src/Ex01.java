import java.util.Scanner;

public class Ex01 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("두 정수와 연산자를 입력하시오 >>");
        String susic = scan.nextLine();
        String arry[] = susic.split("\\s");
        if(arry[2].equals("+")) {
            Calcu add = new Add();
            add.setValue(Integer.parseInt(arry[0]),Integer.parseInt(arry[1]));
            add.calculate();
        }
        else if(arry[2].equals("-")) {
            Calcu add = new Sub();
            add.setValue(Integer.parseInt(arry[0]),Integer.parseInt(arry[1]));
            add.calculate();
        }
        else if(arry[2].equals("*")) {
            Calcu add = new Mul();
            add.setValue(Integer.parseInt(arry[0]),Integer.parseInt(arry[1]));
            add.calculate();
        }
        else if(arry[2].equals("/")) {
            Calcu add = new Div();
            add.setValue(Integer.parseInt(arry[0]),Integer.parseInt(arry[1]));
            add.calculate();
        }
    }
}
