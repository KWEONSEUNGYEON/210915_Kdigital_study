
public class practice02 {
	public static void main(String[] args) {
		abs(-8,7);
		abs(-9, -5);
		abs(5, 4);
	}
	
	public static void abs(int num1, int num2) {
		if(num1>num2)
			System.out.println("�� ���� ���� ���밪 = "+(num1-num2));
		else
			System.out.println("�� ���� ���� ���밪 = "+(num2-num1));
	}
}
