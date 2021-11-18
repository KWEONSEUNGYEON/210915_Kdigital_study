public class Printer implements Printable{
    public static void main(String[] args) {
        Printable prn = new Printer();
        prn.print("기본 생성방법");
//        Printable prn2 = (doc)-> {
//            System.out.println("방금만든람다");
//        };
//        Printable prn3 = new Printable() {
//            @Override
//            public void print(String doc) {
//
//            }
//        };
    }

    @Override
    public void print(String doc) {
        System.out.println(doc+"override...");
    }
}
