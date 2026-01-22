/* Concepts: while loop, Console.ReadLine(), String comparison.

The Scenario: You are building a login screen. The user cannot proceed until they enter the correct password. You don't know how many times they will fail, so a for loop won't work. You need a while loop.

Your Task:

Define a correct password: string password = "1234";.

Create a variable string input = ""; to store what the user types.

Write a while loop.

Condition: Keep looping as long as input is NOT equal to password.

Inside Loop:

Ask: "Enter Password:".

Read input: input = Console.ReadLine();.

If input is wrong: Print "Access Denied. Try again.".

After the loop: Print "Access Granted. Welcome!". */

class Program
{
    static void Main()
    {
        string password = "1234";
        string input = "";
        int i = 0;
        while (i == 0)
        {
            Console.Write("Enter password : ");
            input = Console.ReadLine();
            if(password != input)
            {
                Console.WriteLine("Access Denied. Try again.");
            }
            else
            {
                i = 1;
                Console.WriteLine("Access Granted. Welcome!");
            }
        }
    }   
}