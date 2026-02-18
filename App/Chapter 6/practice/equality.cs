using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


class Program
{
    static void Main()
    {
        var c1 = new Customer { Id = 1, Name = "Alice" };
        var c2 = new Customer { Id = 1, Name = "Alice" };

        bool areEqual = c1.Equals(c2); 
        
        Console.WriteLine($"Are they equal: {areEqual}");
        
        HashSet<Customer> set = [c1,c2];
        
        Console.WriteLine($"Count in HashSet: {set.Count}"); 
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
