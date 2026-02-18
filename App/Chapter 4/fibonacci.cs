using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
	static void Main()
	{
        foreach (int i in Fibs(10)){
            Console.WriteLine(i);
        }
        static IEnumerable<int> Fibs(int num)
        {
            for (int i = 0, curr = 1, prev = 1; i < num; i++)
            {
                yield return curr;
                int newFib = curr + prev;
                prev = curr;
                curr = newFib;
            }
        }
	}	
}