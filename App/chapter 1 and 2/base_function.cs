using System;

public class program {
	
	static void Main(){
		Stock msft = new("Microsoft", 123);
		
		House h1 = new("Villa", 25000);
		
		Console.WriteLine($"House name : {h1.Name}, Mortgage : {h1.Mortgage}");
		Console.WriteLine($"Stock : {msft.Name}, Value : {msft.Value}");
	}

}


class Asset{
	public string Name;
	public Asset(string n){
		Name = n;
	} 
	
}

class Stock : Asset{
	public int Value; 
	public Stock(string n, int val) : base(n){
		Value = val;
	}
}

class House : Asset{
	public int Mortgage;
	public House(string n, int val) : base(n){
		Mortgage = val;
	}
}