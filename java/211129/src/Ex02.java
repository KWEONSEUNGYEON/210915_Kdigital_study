import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Ex02 {
    Ex02() {
        List<String> slist = new ArrayList();
        slist.add("TOM");
        slist.add("BOY");
        slist.add("Robot");

//        출력 방법 1
        Iterator<String> itr = slist.iterator();
        while(itr.hasNext())
        {
            System.out.println(itr.next());
        }

        System.out.println();

//        출력 방법 2
        for(String s : slist) {
            System.out.println(s);
        }
    }

    public static void main(String[] args) {
        new Ex02();
    }
}
