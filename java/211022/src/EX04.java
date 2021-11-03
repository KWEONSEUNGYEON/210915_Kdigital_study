import aa.BankAccount;

public class EX04 {
	public static void main(String[] args) {
		
		BankAccount ref1 = new BankAccount();
		BankAccount ref2 = ref1;
		
		ref1.deposit(1000);
		ref2.checkMybal();
		
		ref2.deposit(2000);
		ref1.checkMybal();
	}
	public void withdraw
}
