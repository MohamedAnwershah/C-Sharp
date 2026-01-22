/* Concepts: Class definition, Fields, Methods, Instantiation.

The Scenario: You are building a school database. You need a standard blueprint for a "Student" so you don't have to manage loose variables everywhere.

Your Task:

Create a Class: Student.

Fields: public string Name; and public int Grade;.

Method: public void Introduce().

It should print: "Hi, I am {Name} and I got a {Grade}.".

Main Program:

Create a new object: Student s1 = new Student();.

Set s1.Name = "Anwershah"; and s1.Grade = 95;.

Call s1.Introduce();. */

using System;

class Program
{
	static void Main()
	{
		Student s1 = new("Shah", 8.5);
        s1.Introduce();
	}	

    
}

class Student(string name, double grade)
{
    public string Name = name;
    public double Grade = grade;

    public void Introduce()
    {
        Console.WriteLine($"Hi, I am {Name} and I got a {Grade}.");
    }
    
}