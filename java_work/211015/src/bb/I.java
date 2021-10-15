package bb;

public class I {
	public static void main(String[] args) {
		int num1 = 11;
		int num2 = 22;
		boolean result;
		
		result = num1<num2;
		System.out.println("result ="+result);
	
		result =num1 <num2 && num1 >100;
		System.out.println("result ="+result);
		
		result =num1 <num2 || num1 <100;
		System.out.println("result ="+result);
	}
	
}
