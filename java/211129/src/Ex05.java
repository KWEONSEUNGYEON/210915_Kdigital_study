import java.util.HashMap;
import java.util.Map;
import java.util.Set;

public class Ex05 {
    public static void main(String[] args) {
        Map<Integer,String> map = new HashMap<>();

        map.put(1, "aaa");
        map.put(2, "bbb");
        map.put(3, "ccc");

        System.out.println(map);

        System.out.println(map.get(1));
        System.out.println(map.get(2));
        System.out.println(map.get(3));

        System.out.println();
        Set<Integer> keys =  map.keySet();
        for(Integer key : keys) {
            System.out.println(map.get(key));
        }
    }
}
