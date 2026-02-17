<Query Kind="Statements" />

Octopus oct1 = new(10);

oct1.Hello();

double circle = 2 * MathUtils.pi * 5;
Console.WriteLine($"Area : {circle}");

DateTime time = serverConfig.startTime;
Console.WriteLine($"Server time : {time}");

public class Octopus {
	public string name = "Shah"; //fields
	public readonly int legs = 8;
	
	public Octopus(int Newlegs){
		legs = Newlegs; //can change readonly in constructor
	}
	
	public void Hello(){
		Console.WriteLine($"Hey iam {name}, and i have {legs}.");
	}

}

public class MathUtils {
	public const double pi = 3.14D; //constant value wont change
	public const string version = "2.0";
}

public class serverConfig{
	public static readonly DateTime startTime = DateTime.Now; //static value
	public const int maxServers = 100;
}
