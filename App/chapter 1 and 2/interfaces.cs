using System;
using System.Threading.Tasks;
using System.Collections.Generic;

class Program{
	static void Main(){
		Store amazon = new();
		
		Crypto bitcoin = new();
		
		amazon.CheckOut(bitcoin, 100);
	}
}

interface IPaymentMethod{
	void ProcessPayment(int amount);
}

class CreditCard : IPaymentMethod{
	public void ProcessPayment(int amount){
		Console.WriteLine("Credit Card processing...");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Processing... { (i + 1) * 33}%");
            Thread.Sleep(500);
        }
        Console.WriteLine("Crypto Payment processed.");
	}
}

class Crypto : IPaymentMethod {
	public void ProcessPayment(int amount){
		Console.WriteLine("Crypto Payment processing...");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Processing... { (i + 1) * 33}%");
            Thread.Sleep(500);
        }
        Console.WriteLine("Crypto Payment processed.");
	}	
}

class PayPal : IPaymentMethod {
	public void ProcessPayment(int amount){
		Console.WriteLine("PayPal payment Processing...");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Processing... { (i + 1) * 33}%");
            Thread.Sleep(500);
        }
        Console.WriteLine("Crypto Payment processed.");

	}
}	

class Store{
	public void CheckOut(IPaymentMethod paymentMethod, int amount){
		paymentMethod.ProcessPayment(amount);
	}
}

