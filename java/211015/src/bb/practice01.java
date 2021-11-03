package bb;

public class practice01 {
	public static void main(String[] args) {
		//巩力 1
//		int num1 = 10;
//		int num2 = 20;
//		int num3 = 30;
//		num1 = num2 = num3;
//		
//		System.out.println(num1);
//		System.out.println(num2);
//		System.out.println(num3);
		
		//巩力 2
        int num1 = 0; 
        int num2 = 0;
        boolean result;

        num1 += 10;
        num2 += 10;        
        result = (num1 < 0) && (num2 > 0);

        System.out.println("result = " + result);
        System.out.println("num1 = " + num1);
        System.out.println("num2 = " + num2 + '\n');
		
        num1 += 10;
        num2 += 10;        
        result = (num1 > 0) || (num2 > 0);

        System.out.println("result = " + result);
        System.out.println("num1 = " + num1);
        System.out.println("num2 = " + num2);
        
		//巩力 3
//		int result = ((25*5)+((36-4)-72))/5;
//		System.out.println(result);
		
		//巩力 4
//		int result = 3+6;
//		System.out.println("3 + 6 = "+result);
//		result +=9;
//		System.out.println("3 + 6 + 9 = "+result);
//		result +=12;
//		System.out.println("3 + 6 + 9 + 12 = "+result);
		
		//巩力 5
//		boolean result;
//		int n1 = ((25+5)+(36/4)-72)*5;
//		int n2 = ((25*5)+(36-4)+71)/4;
//		int n3 = (128/4)*2;
//		System.out.println(n1);
//		System.out.println(n2);
//		System.out.println(n3);
		
//		result = (n1>n2) && (n2>n3);
//		System.out.println("result = "+result);
	}
}
