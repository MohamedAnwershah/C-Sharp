using System;

class Program {
	static void Main(){
		Car toyota = new(1885, "Toyota");
        if (toyota.Year == 0){
            Console.WriteLine("Car year is not set due to invalid value.");
        } else {
            toyota.Drive();
        }
        
	}
}

class Car{
	private int _year;
	public int Year{
	get{
		return _year;
	}
	set{
		if (value >= 1886) _year = value;
		else Console.WriteLine("Error!");
	}
	}
	public string Make;
	public string Name;

	public Car(int year, string make){
		Year = year;
		Make = make;
	}
	

	
	public void Drive(){
		Console.WriteLine($"Driving the {_year}, {Make}");
	}
}