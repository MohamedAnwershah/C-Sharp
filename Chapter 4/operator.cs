using System;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;

class Program
{
	static void Main()
	{
		Vector v1 = new(10, 12);
        Vector v2 = new(5,6);

        var v3 = v1 + v2;

        Console.WriteLine($"X : {v3.X}, Y : {v3.Y}");
    }
}

class Vector(int x, int y)
{
    public int X = x, Y = y;

    public static Vector operator + (Vector a, Vector b)
    {
        Vector result = new(a.X + b.X, a.Y + b.Y);
        
        return result;
    }
}