using System;

class Program
{
	static void Main()
	{
		var c1 = new Player("Alice", 100);
        var c2 = new Player("Anwer", 20);
        var c3 = new Player("Nawf", 50);

        List<Player> players = [c1, c2, c3];

        /* Create a class NameSorter that implements IComparer<Player>.

        Fill in the Compare(x, y) method to sort by Name.

        Pass new NameSorter() into players.Sort(). */

        players.Sort(); //default sort by score
        Console.WriteLine("\nSorted by Score :");
        foreach(var player in players)
        {
            Console.WriteLine($"{player.Name} : {player.Score}");
        }


        /* Keep your Player class (which sorts by Score).

        Add the NameSorter class.

        In Main, create the list, print it (default sort), then sort with NameSorter and print it again (alphabetical). */

        players.Sort(new NameSorter());
        Console.WriteLine("\nSorted by Name : ");
        foreach(var player in players)
        {
            Console.WriteLine($"{player.Name} : {player.Score}");
        }
	}

}

class Player (string name, int score) : IComparable<Player>
{
    public string Name = name;
    public int Score = score;

    public int CompareTo(Player? other)
    {
        if (other == null)
        {
            return 1;
        }
        return this.Score.CompareTo(other.Score);
        
    }
}
//custom sorting method

class NameSorter : IComparer<Player>
{
    public int Compare(Player? x, Player? y)
    {
        

        return x.Name.CompareTo(y.Name);
    }
}