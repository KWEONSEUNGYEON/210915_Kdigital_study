//이클립에서는 저장하는 순간 컴파일 함
//A.java -> A.class
public class d {

	public static void main(String[] args) {
		int a = 10;
		double b=20;
		b=a;
		System.out.println("b = "+b);
		a=(int)b;
		System.out.println("a = "+a);
	}
	
}
