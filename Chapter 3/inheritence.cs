using System;
using System.Text;

class Program{
	static void Main(){
		Car car1 = new("Honda");
		
		car1.StartEngine();
		car1.Honk();
		Console.WriteLine(car1.Name);
	}
}

class Vehicle{
	public string Name;
	public Vehicle(string name)
	{
		Name = name;
	}
	public void StartEngine(){
		Console.WriteLine("Vroom Vroom");
	}
}

class Car : Vehicle{
	public Car(string name) : base(name)
	{

	}
	public void Honk(){
		Console.WriteLine("Beep!");
	}

}