class program{
	static void Main(){
		Bank acc1 = new(100000);
		acc1.Check();
		acc1.Withdraw(5000);
		acc1.Deposit(1000);
		
		Bank acc2 = new(20000);
		Bank acc3 = new(50000);
		Bank acc4 = new(4000);
		
		Console.WriteLine($"Total accounts : {Bank.TotalAccounts}");
		
	}

}

class Bank
{
	public int Balance {get; private set;}
	public static int TotalAccounts;
	public Bank(int init_bal){
		Balance = init_bal;
		TotalAccounts++;
	}
	public void Withdraw(int amount){
		if (amount > 0 && amount <= Balance) {
		Balance -= amount;
		Console.WriteLine($"Withdrew - Rs.{amount}");
		Console.WriteLine($"New Balance : Rs.{Balance}");
		}
		else Console.WriteLine($"Unable to Withdraw Rs.{amount}");
	}
	public void Deposit(int amount){
		if (amount > 0) {
		Balance += amount;
		Console.WriteLine($"Deposited + Rs.{amount}");
		Console.WriteLine($"New Balance : Rs.{Balance}");
		}
		else Console.WriteLine($"Enter a positive Value!");	
	}
	public void Check(){
		Console.WriteLine($"Current Balance : Rs.{Balance}");
	}
}