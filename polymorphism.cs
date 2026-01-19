using System;

class program{
	static void Main(){
		Shape shape = new();
		Circle circle = new();
		Square square = new();
		
		square.Draw();
		circle.Draw();
		shape.Draw();
	}
	
}

class Shape{
	
	public virtual void Draw(){ //parent
		Console.WriteLine("Drawing..");
	}
}

class Circle : Shape {
	public override void Draw(){
		Console.WriteLine("Drawing : O");
	}
}

class Square : Shape {
	public override void Draw(){
		Console.WriteLine("Drawing : []");
	}
}