
//������ �� ��� ctrl+1������ ���� ����
//���� �����ߴµ� ������ �ȵǾ��� ��� src������ F5 ���ΰ�ħ�ϱ�
//final�� �����Ұ�
package bb;

public class A {
	public static void main(String[] args) {
		int MIN_SIZE = 200; //���氡��
		final int MAX_SIZE =100; //����Ұ�
		
		System.out.println("MAX_SIZE = "+MAX_SIZE);
		System.out.println("MIN_SIZE = "+MIN_SIZE);
		MIN_SIZE = 300;	
		System.out.println("MIN_SIZE = "+MIN_SIZE);
	//	MAX_SIZE = 200;
	}
}
