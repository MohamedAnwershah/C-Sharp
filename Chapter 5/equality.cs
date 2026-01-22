
/* Create Class: class Person { public string Name; }.

Main Program:

Create p1 with Name = "Shah".

Create p2 with Name = "Shah". (Same data, new object).

Create p3 = p1; (Copying the reference).

Compare:

Print p1 == p2 (Expect: False).

Print p1 == p3 (Expect: True). */

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

class Person(string name)
{
    string Name = name;
}