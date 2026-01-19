using System;

class program{
	static void Main(){
		Donkey d = new(){
			Name = "Donkey",
		};
		d.MakeSound();
	}
}

abstract class Animal(){
	public string Name = "";
	
	public abstract void MakeSound();
	
	public void Sleep(){
		Console.WriteLine("Zzzzz.....");
	}
}

class Donkey : Animal{
	public override void MakeSound(){
		Console.WriteLine("Donkey noise..");
	}
}

class Sheep : Animal {
	public override void MakeSound(){
		Console.WriteLine("Sheep noise...");
	}
}