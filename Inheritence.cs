using System;

public class program {
	
	static void Main(){
		Stock msft = new(){
			Name = "Microsoft",
			Value = 123
		};
		
		House h1 = new(){
			Name = "Villa",
			Mortgage = 25000
		};
		
		Console.WriteLine($"House name : {h1.Name}, Mortgage : {h1.Mortgage}");
		Console.WriteLine($"Stock : {msft.Name}, Value : {msft.Value}");
	}

}


class Asset{
	public string Name; 
}

class Stock : Asset{
	public int Value; 
}

class House : Asset{
	public int Mortgage;
}