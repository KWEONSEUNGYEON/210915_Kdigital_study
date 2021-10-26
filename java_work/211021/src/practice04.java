
public class practice04 {
	public static void main(String[] args) {
		prime(13);
		prime(2);
		prime(4);
	}
	
	public static void prime(int num1) {
		if(num1%1==0 | num1%num1==0)
			System.out.println("true");
		else
			System.out.println("false");
	}
}
