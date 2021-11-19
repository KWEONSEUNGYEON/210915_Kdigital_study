import java.io.FileWriter;
import java.io.IOException;

class AA{
    public AA() throws IOException{
        System.out.println("AA생성자 호출할때 IOException이 발생할 수도 있다는 것을 명시...");
    }
}

public class Ex04 {
    public static void md1(){

        try {
            md2();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public static void md2() throws IOException {
        FileWriter writer = new FileWriter("a.txt");
        writer.write("글을 씁니다.");
        writer.close();
    }

    public static void main(String[] args) throws IOException {
        md1();
        new AA();
    }
}
