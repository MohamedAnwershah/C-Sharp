using System;

class Program{
	static void Main(){
		PointClass pc1 = new(10, 5);
		PointClass pc2 = pc1;
		pc2.X = 100; //updates pc1 as well (pointer)
		
		PointStruct ps1 = new(12, 6);
		PointStruct ps2 = ps1;
        ps1.X = 
		ps2.X = 120; //updates only ps2
		
		
		
		Console.WriteLine(pc1.X);
		Console.WriteLine(ps1.X);		
	
	}
}

class PointClass {
	public int X, Y;
	public PointClass(int x, int y){
		X = x;
		Y = y;
	}
}

struct PointStruct {
	public int X, Y;
	public PointStruct(int x, int y){
		X = x;
		Y = y;
	}
}

