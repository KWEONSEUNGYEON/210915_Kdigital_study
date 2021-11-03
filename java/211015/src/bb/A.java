
//에러가 뜰 경우 ctrl+1누르고 에러 수정
//파일 수정했는데 적용이 안되었을 경우 src누르고 F5 새로고침하기
//final은 수정불가
package bb;

public class A {
	public static void main(String[] args) {
		int MIN_SIZE = 200; //변경가능
		final int MAX_SIZE =100; //변경불가
		
		System.out.println("MAX_SIZE = "+MAX_SIZE);
		System.out.println("MIN_SIZE = "+MIN_SIZE);
		MIN_SIZE = 300;	
		System.out.println("MIN_SIZE = "+MIN_SIZE);
	//	MAX_SIZE = 200;
	}
}
