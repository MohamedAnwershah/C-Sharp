#define PREMIUM_VERSION

class Program
{
    static void Main()
    {
        #if PREMIUM_VERSION 
        Console.WriteLine("Welcome Premium User");

        #else
        Console.WriteLine("Hello free user");

        #endif
    }
}