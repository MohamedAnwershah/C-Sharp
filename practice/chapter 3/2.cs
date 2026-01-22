/* Concepts: Base Class, Derived Class, virtual, override.

The Scenario: You are building a game with different types of characters.

A generic Character can move.

A Wizard moves differently (teleports).

A Knight moves differently (marches).

You need to use Polymorphism so the game engine doesn't need to know exactly which class is which.

Your Task:

Create Base Class: Character.

Method: public virtual void Move() -> Print "Walking...". (Note the virtual).

Create Derived Class: Wizard (inherits from Character).

Method: public override void Move() -> Print "Teleporting!".

Create Derived Class: Knight (inherits from Character).

Method: public override void Move() -> Print "Marching in armor!".

Main Program:

Create a list: List<Character> party = new();.

Add a new Wizard() and a new Knight() to it.

Loop through the list and call .Move() on each item.

Observation: See how the correct method runs automatically. */

using System;
using System.Security.Cryptography;

class Program
{
    
	static void Main()
	{
        Wizard w1 = new();
        Knight k1 = new();
		List<Character> characters = [w1, k1];
        foreach (Character c in characters)
        {
            c.Move();
        }

	}	
}

class Character
{
    public virtual void Move()
    {
        Console.WriteLine("Character Walking..");
    }
}

class Wizard : Character
{
    public override void Move()
    {
        Console.WriteLine("Teleporting!");
    }
}

class Knight : Character
{
    public override void Move()
    {
        Console.WriteLine("Marching!");
    }
}
