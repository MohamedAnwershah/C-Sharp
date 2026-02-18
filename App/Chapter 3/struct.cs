using System;

class Program{
	static void Main(){
		RefPoint r1 = new() {X = 10};
		
		StructPoint s1 = new() {X = 10};
		
		RefPoint r2 = r1;
		r2.X = 100;
		StructPoint s2 = s1;
		s2.X = 100;
		
		Console.WriteLine($"Ref : {r1.X}, Val : {s1.X}");
		
	}
}

class RefPoint{
	public int X;
	public string Name;
}
struct StructPoint{
	public int X;
}