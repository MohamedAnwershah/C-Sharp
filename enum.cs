using System;

class Program{
	static void Main(){
		PizzaSize myOrder = PizzaSize.Medium;
		
		if (myOrder == PizzaSize.Small){
			Console.WriteLine("Your Total is $5.99");
		}
		if (myOrder == PizzaSize.Medium){
			Console.WriteLine("Your Total is $8.99");
		}
		if (myOrder == PizzaSize.Large){
			Console.WriteLine("Your Total is $10.99");
		}
	}
}

enum PizzaSize{
	Small,
	Medium,
	Large
}