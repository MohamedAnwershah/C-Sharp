using System;


class Program{
	static void Main(){
		
		Manager arun = new();
		arun.CheckBalance();
		//arun.Balance = 100; //gives error
	
	}
}

class BankVault{
	private int SecretCode = 1234;
	protected int Balance = 10000;
	public void ShowInfo(){
		Console.WriteLine("Information of the Vault");
	}
}

class Manager : BankVault{
	public void CheckBalance(){
		Console.WriteLine($"Balance : ${Balance}");
		//Console.WriteLine(SecretCode); //gives error
	}
	
}