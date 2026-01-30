using System;

class Program
{
	static void Main()
	{
		HashSet<string> brideList = ["Alice", "Bob", "Charlie", "Alice"];
        HashSet<string> groomList = ["Charlie", "Dave", "Bob", "Eve"];

        brideList.UnionWith(groomList);
        Console.WriteLine("All guestes : ");
        foreach(string name in brideList)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("Knows both : ");
        brideList = ["Alice", "Bob", "Charlie", "Alice"];
        groomList = ["Charlie", "Dave", "Bob", "Eve"];
        brideList.IntersectWith(groomList);
        foreach(string name in brideList)
        {
            Console.WriteLine(name);
        }
	}

}
