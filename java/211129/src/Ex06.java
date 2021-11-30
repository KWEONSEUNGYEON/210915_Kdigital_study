import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Collections;

public class Ex06 {
    public static void main(String[] args) {

        List<Integer> list = Arrays.asList(1,2,5,3,4);
        List<String> slist = Arrays.asList("aa", "dd" ,"cc", "bb", "ee");

        System.out.println(list);
        Collections.sort(list);
        System.out.println(list);

        System.out.println(slist);
        Collections.sort(slist);
        System.out.println(slist);

    }
}
