
/* Create: int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

Group: Group them by n % 2 == 0 (The Key will be true for Evens, false for Odds).

Loop:

Print the Key (True/False).

Loop through the numbers in that group and print them. */

using System;

class Program
{
	static void Main()
	{
		int[] nums = [1,2,3,4,5,6,7,8,9];

        var groups = nums.GroupBy(n => n % 2 == 0);

        foreach (var group in groups)
        {
            if(group.Key == true)
            {
                Console.WriteLine("Even Numbers");
            }
            else
            {
                Console.WriteLine("Odd numbers");
            }

            foreach (int num in group)
            {
                Console.WriteLine(num);
            }
        }
	}	
}