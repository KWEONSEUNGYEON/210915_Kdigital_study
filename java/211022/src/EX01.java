
public class EX01 {
	public static void main(String[] args) {
		System.out.println(fact(3));
	}
	public static int fact(int num) {
		if(num==1)
			return num;
		else
			return num * fact(num-1);
	}
}
