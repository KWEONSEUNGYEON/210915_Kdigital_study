public class Ex01 {
    public static void main(String[] args) {
        String a = new String("abcedfg");
        String b = "abcdefggg";
//        방법 1
//        System.out.println(a);
//        System.out.println(a.length());
//        System.out.println();
//
//        System.out.println(b);
//        System.out.println(b.length());
//        System.out.println();

//        방법 2
        showString(a);
        showString(b);
        showString("abcdefgasdf");
    }

    public static void showString(String c) {
        System.out.println(c);
        System.out.println(c.length());
        System.out.println();
    }

}
