
public class EX02 {
	public static int bal =0;
	
	public static void main(String[] args) {
		deposit(10000);
		checkMybal();
		withdraw(3000);
		checkMybal();
		System.out.println("bal ="+bal);
	}
	
	public static int deposit(int num) {
		bal+=num;
		return bal;
	}
	public static int withdraw(int num) {
		bal-=num;
		return bal;
	}
	public static int checkMybal(int num) {
		System.out.println("ภÜพื : "+bal);
		return bal;
	}
}

