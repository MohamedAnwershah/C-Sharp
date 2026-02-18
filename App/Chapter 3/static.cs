using System;

class Program{
	static void Main(){
		Player p1 = new();
		Player p2 = new();
		Player p3 = new();
		
		Console.WriteLine(Player.PlayerCount);
	}
}
class Player{
	public static int PlayerCount = 0;
	public Player(){
		PlayerCount++;
	}
}