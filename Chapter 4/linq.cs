using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> numbers = new(){1,2,3,4,5,6,7,8,9,10};
        //where - condition
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Even Numbers");
        foreach (int num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        //select - modifying the elements inside
        var squares = numbers.Select(n => n * n).ToList();
        Console.WriteLine("\nSquare - select");
        foreach (int num in squares)
        {
            Console.WriteLine(num);
        }

        //chaining linq
        var evenSquares = numbers.Where(n => n % 2 == 0).Select(n => n * n).ToList();
        Console.WriteLine("\nEven Squares - Chaining");
        foreach (int i in evenSquares)
        {
            Console.WriteLine(i);
        }

        //sorting
        List<string> names = new() { "Anwershah", "Ali", "Mohamed", "Nawf" };
        Console.WriteLine("\nSorting");
        var sortedNames = names.OrderBy(n => n.Length).ToList();
        foreach(string name in sortedNames)
        {
            Console.WriteLine(name);
        }
    }
}