import java.util.Random;

public class Ex06 {

    public static void main(String[] args) {
        Random ran1 = new Random(System.currentTimeMillis());
        for(int i =0; i<7; i++)
            System.out.println(ran1.nextInt(1000));
    }
}
