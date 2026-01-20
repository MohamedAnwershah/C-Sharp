using System.Collections.Generic;

class Program{
	static void Main(){
		List<string> shoppingList = new();
		shoppingList.Add("egg");
		shoppingList.Add("Milk");
		shoppingList.Add("Bread");
		
		Console.WriteLine("Before :");
		foreach (string item in shoppingList){
			Console.WriteLine(item);
		}
		shoppingList.Remove("Bread");
		
		Console.WriteLine("\nAfter :");
		foreach (string item in shoppingList){
			Console.WriteLine(item);
		}
		Console.WriteLine(shoppingList.Count()); //count
		Console.WriteLine(shoppingList[0]); //first item
	}
}

