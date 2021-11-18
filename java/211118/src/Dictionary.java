import java.util.Scanner;

public class Dictionary {
    private static String[] kor = {"사랑", "아기", "돈", "미래", "희망"};
    private static String[] eng = {"love", "baby", "money", "future","hope"};
    public static String kor2Eng(String word) {
        for(int i = 0; i< kor.length; i++) {
            if(kor[i].equals(word))
                return word + "는(은) " + eng[i] + "입니다.";
        }
        return word + "는(은) 사전에 없습니다";
    }

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        System.out.println("한영 단어 검색 프로그램입니다.");
        while(true) {
            System.out.print("한글 단어? ");
            String word = scan.nextLine();
            if(word.equals("그만"))
                break;
            System.out.println("word = "+word);
            String result = kor2Eng(word);
            System.out.println(result);
        }

    }
}
