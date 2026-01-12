using System;

Bank b = new(100000);
Console.WriteLine($"Balance : {b.Balance}");
b.Balance = 1000;
Console.WriteLine($"New balance : {b.Balance}");

class Bank {
	private int _balance = 0;
	
	public int Balance{
		get{
			return _balance;
		}
		set {
			if (value > 0) _balance = value;
			else Console.WriteLine("Error, Cannot update the Balance!");
		}
	}
	
	public Bank (int bal){
		Balance = bal;
	}
}