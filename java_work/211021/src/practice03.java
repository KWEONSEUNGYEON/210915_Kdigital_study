
public class practice03 {
	public static void main(String[] args) {
		System.out.println("���� ���� = "+ Circle(2.4));
		System.out.println("���� �ѷ� = "+ Circle2(2.4));
	}
	public static double Circle(double num1) {
		double PI = 3.14;
		return num1*num1*PI;
	}
	public static double Circle2(double num1) {
		double PI = 3.14;
		return num1*2*PI;
	}
}
