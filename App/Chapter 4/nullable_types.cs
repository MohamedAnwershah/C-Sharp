using System;

class Program
{
	static void Main()
	{
		ShowId(10); //prints 10
        ShowId(null); //prints Error!
	}	

    static void ShowId(int? id)
    {
        if (id.HasValue)
        {
            Console.WriteLine(id);
        }
        else
        {
            Console.WriteLine("Error!");
        }
    }

}