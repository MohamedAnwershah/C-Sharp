using System;

class Program{
	static void Main(){
		Boat b1 = new();
		b1.Move();
		
		Car c1 = new();
		c1.Move();
		
		Vehicle v1 = new();
		v1.Move();
	}
}

class Vehicle {
	public virtual void Move(){
		Console.WriteLine("Generic Movement..");
	}
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