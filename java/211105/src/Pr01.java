// questions3_String.txt

import java.util.Scanner;

public class Pr01 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

//        1번
        System.out.print("이름을 성과 이름을 띄워서 영어로 입력 ");
        String inputString = scan.nextLine();
        System.out.println("출력 "+inputString);
        String ar[]=inputString.split(" ");
        System.out.println("성 = "+ar[0]);
        System.out.println("이름 = "+ar[1]);
        System.out.println();

//        2번
        System.out.print("입력 ");
        String inputString2 = scan.nextLine();
        System.out.println("출력 "+inputString2);
        String ar2[]=inputString2.split("\\.");
        System.out.println("파일명 = "+ar2[0]);
        System.out.println("확장자 = "+ar2[1]);
        System.out.println();

//        3번
        while(true) {
            System.out.println("1. 더하기 2. 빼기 3. 나누기 4. 곱하기 5. 나머지 6. 종료");
            System.out.print("무엇을 하시겠습니까?");
            int select = scan.nextInt();

            if (select == 6) {
                System.out.println("종료합니다.");
                break;
            }

            System.out.print("첫번째 수 ");
            int num = scan.nextInt();
            System.out.print("두번째 수 ");
            int num2 = scan.nextInt();

            if (select == 1) {
                System.out.println(num + "+" + num2 + "=" + (num + num2));
            }
            else if (select == 2) {
                System.out.println(num + "-" + num2 + "=" + (num - num2));
            }
            else if (select == 3) {
                System.out.println(num + "/" + num2 + "=" + (num / num2));
            }
            else if (select == 4) {
                System.out.println(num + "*" + num2 + "=" + (num * num2));
            }
            else if (select == 5) {
                System.out.println(num + "%" + num2 + "=" + (num % num2));
            }
        }
        System.out.println();
//        4번
        String numbers[] = {"one","two","three","four","five","six","seven","eight","nine"};
        Scanner scan2 = new Scanner(System.in);
        System.out.print("글자 입력 ");
        String inputString3 = scan2.nextLine();
        for (int i =0; i<numbers.length; i++) {
            inputString3 = inputString3.replaceAll(numbers[i], (i+1)+"");
        }
//        String.valueOf(i+1) = (i+1)+""
//        for (int i =0; i<numbers.length; i++) {
//            inputString3 = inputString3.replaceAll(String.valueOf(i+1), numbers[i]);
//        }
        System.out.println("inputString = "+inputString3);

    }
}
