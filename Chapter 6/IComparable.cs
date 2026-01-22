
/* Update Record: record Person(string Name) : IComparable<Person> (Inherit the interface).

Implement Method:

C#
public int CompareTo(Person other)
{
    // Use the built-in string comparison
    return this.Name.CompareTo(other.Name);
}
Main Program:

Create a list: List<Person> people = [new("Zara"), new("Alex"), new("Shah")];.

Call people.Sort();.

Loop and print the names.

Observation: They should print as Alex, Shah, Zara. */

using System;

class Program
{
	static void Main()
	{


        List<Person> people = [new("Zara"), new("Alex"), new("Shah")];
        people.Sort();
        foreach(Person p in people)
        {
            Console.WriteLine(p.Name);
        }
	}	
}
record Person(string name) : IComparable<Person>
{
    public string Name = name;

    public int CompareTo(Person other)
    {   
        if (other is null) return 1;
        return this.Name.CompareTo(other.Name);
    }
}