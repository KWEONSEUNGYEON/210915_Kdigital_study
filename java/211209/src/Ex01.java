import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Ex01 {
    public static void main(String[] args) {

        List<String> li = Arrays.asList("aa","bbb","ccc","ddd");
        List<String> li1 = new ArrayList<>(li);

        li1.stream().filter(s-> s.length()>2).forEach(s-> System.out.println(s));
    }
}
