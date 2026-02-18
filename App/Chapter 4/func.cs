using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program
{
	static void Main()
	{
        // Func<int, bool> function;
		// function = x => (x % 2 == 0);
        List<int> nums = [1,2,3,4,5,6,7,8,9];
        FilterList(nums, x => (x % 2 == 0)); //simplified without a variable
    }	
    static void FilterList(List<int> numbers, Func<int, bool> check)
    {
        
        foreach (int num in numbers)
        {
            if (check != null){
                if (check(num))
                {
                    Console.WriteLine(num);
                }  
            }
        }
    }
    
}