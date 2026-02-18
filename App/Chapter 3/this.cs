using System;

class Program
{
    static void Main()
    {
        Employee u1 = new("Anwer");
        Console.WriteLine(u1.name);
    }
}

class Employee
{
    public string name;

    public Employee(string name)
    {
        this.name = name;
    }
}