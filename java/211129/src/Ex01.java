import java.util.ArrayList;
import java.util.List;

/* 컬렉션과 제네릭을 같이 씀

 */


import java.util.ArrayList;

public class Ex01 {
    public static void main(String[] args) {
        List<String> slist = new ArrayList<>();
        List<Integer> ilist = new ArrayList<>();

        slist.add("문자열1");
        slist.add("문자열2");
        slist.add("문자열3");

        ilist.add(1);
        ilist.add(2);
        ilist.add(3);

        System.out.println(slist);
        System.out.println(ilist);
    }
}
