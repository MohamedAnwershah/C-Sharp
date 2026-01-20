using System;

class Program{
	static void Main(){
		Boat b1 = new();
		b1.Move();
		
		Car c1 = new();
		c1.Move();
	}
}

abstract class Vehicle {
	public abstract void Move();
}

class Car : Vehicle {
	public override void Move(){
		Console.WriteLine("Driving in a road..");
	}
}

class Boat : Vehicle {
	public override void Move(){
		Console.WriteLine("Sailing on water..");
	}
}