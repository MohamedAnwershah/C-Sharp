using System;
class Program {
static void Main()
{
	Person p1 = new("Shah", 21);
	Console.WriteLine(p1);
}
}
class Person{
	string Name;
	int Age;
	public Person(string n, int a){
		Name = n;
		Age = a;
	}
	public override string ToString(){
		return $"Iam {Name}, {Age} y/o";
	}
}
