using System;

class Program{
	static void Main(){
		Money m1 = new(100, "USD");
		Money m2 = new(150, "USD");
		Money total = m1 + m2;
		
		Console.WriteLine($"Total : {total.Amount}");
	}
}

readonly struct Money{
	public decimal Amount{get;}
	public string Currency{get;}
	
	public Money(decimal val, string curr){
		Amount = val;
		Currency = curr;
	}
	
	public static Money operator +(Money a, Money b){
		if (a.Currency != b.Currency) throw new Exception ("Currency missmatch !");
		return new Money(a.Amount + b.Amount, a.Currency);
	}
}
