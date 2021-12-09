import java.util.Optional;

public class Ex03 {
    public static void main(String[] args) {
        Optional<Friend> f1 = Optional.of(new Friend(null, null));

        String name = f1.map(friend -> friend.getName()).orElse("이름없음");

        System.out.println("name = "+name);
    }
}
