public class Ex03 {
    public static void main(String[] args) {
        double e = 3.1415;
        String f = "3";
//      문자열 변환 두가지 방법

//      1. String.valueof 함수 사용
        String a = String.valueOf(e);

//      2. 문자열 더하면 자동으로 문자열로 형변환
        String b = e + "";

        System.out.println("a = "+a);
        System.out.println("b = "+b);
//        3. String을 int형변환
        int c = Integer.parseInt(f);
//        4. String을 double형변환
        double d = Double.parseDouble(a);

        System.out.println("d = "+d);
        System.out.println("c = "+c);
    }
}
