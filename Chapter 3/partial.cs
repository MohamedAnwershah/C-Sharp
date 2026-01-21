using System;
using System.Globalization;

class Program
{
	static void Main()
    {
		Payment paypal = new();
		paypal.Pay();

		Payment.AddCard("MasterCard");
	}	
}

partial class Payment
{
	public void Pay()
	{
		Console.WriteLine("Paid.");
	}
}

partial class Payment
{
	public static List<string> Cards = new();
	public static void AddCard(string card)
	{
		Cards.Add(card);
		Console.WriteLine($"{card} successfully added!");
	}
}