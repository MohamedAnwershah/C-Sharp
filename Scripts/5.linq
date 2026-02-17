<Query Kind="Statements" />

Panda p1 = new Panda("Dhanusri");
Console.WriteLine(p1.name);
Console.WriteLine($"Population of Pandas : {Panda.population}\n");

Panda p2 = new Panda("Khadhija"); //creates a new instance of Panda
Console.WriteLine(p2.name);

Console.WriteLine($"Population of Pandas : {Panda.population}");


public class Panda
{
	public static int population;
	public string name;
	public Panda(string input)
	{
		name = input;
		population = population + 1;
		
	}
	
}


