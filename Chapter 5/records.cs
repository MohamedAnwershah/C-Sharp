
/* Define: Change your class Person to record Person(string Name);.

(You can verify it works just like a class).

Main Program:

Create p1 with Name "Shah".

Create p2 with Name "Shah" (Identical Data).

Compare:

Print p1 == p2.

Observation: It should now print True. */

using System;

class Program
{
	static void Main()
	{
		Person p1 = new("Shah");
        Person p2 = new("Shah");
        Person p3 = p1;
        Console.WriteLine(p1 == p2);
        Console.WriteLine(p1 == p3);
	}	
}

record Person(string name)
{
    string Name = name;
}