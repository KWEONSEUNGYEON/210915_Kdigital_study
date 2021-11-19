import java.io.FileWriter;
import java.io.IOException;

public class Ex02 {
    public static void main(String[] args) {
        try {
            int a = 10;
            int b = 0;

            System.out.println(a/b);
        }
        catch (Exception e) {
            System.out.println("프로그램이 상태가 안조항요.");
            System.out.println("다시 만드세요");
            try {
                FileWriter fileWriter = new FileWriter("text.txt");
                fileWriter.write("프로그램상태가 안좋아요.");
                fileWriter.close();
            } catch (IOException ex) {
                ex.printStackTrace();
            }
            e.printStackTrace();
        }
        System.out.println("프로그램을 종료합니다.");
    }
}
