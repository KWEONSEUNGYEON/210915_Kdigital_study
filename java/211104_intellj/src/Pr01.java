import java.util.Scanner;

public class Pr01 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.printf("인원수");
        int count = sc.nextInt();
            for(int i=1; i<=count; i++) {
                System.out.printf("이름과 전화번호(이름과 번호는 빈칸없이 입력)");
                String name = sc.nextLine();
            }
    }
}