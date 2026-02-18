using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


class Program
{
    static void Main()
    {
        var c1 = new Customer { Id = 1, Name = "Alice" };
        var c2 = new Customer { Id = 1, Name = "Alice" };

        Dictionary<Customer, decimal> bank = [];

        bank.Add(c1, 500);
        Console.Write(bank[c2]);
    }
}
class Customer 
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public override bool Equals(object? obj)
    {
        if (obj is Customer other)
        {
            return this.Id == other.Id;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }
}
