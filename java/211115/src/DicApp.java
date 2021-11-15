import java.util.Scanner;

class Dictionary {
    private static String[] kor = {"사랑", "아기", "돈", "미래", "희망"};
    private static String[] eng = {"love", "baby", "money", "future","hope"};
//    public static String kor2Eng(String word) { /*검색 코드 작성*/ };
}

public class DicApp {
    DicApp() {
        Scanner scan = new Scanner(System.in);

        System.out.println("한영 단어 검색 프로그램입니다.");
        System.out.println("한글 단어?");
        String kor = scan.nextLine();
    }

}
