class Program
{
    static void Main()
    {
        BankAccount u1 = new();

        // u1.WithDraw(500); //throws an excemption
        try
        {
            u1.WithDraw(500);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction Completed!");
        }
    }
}

class BankAccount
{
    private int Balance = 100;

    public void WithDraw(int amount)
    {
        if (amount > Balance)
        {
            throw new Exception("Cannot withdraw!"); //excemption here
        }
        else
        {
            Balance -= amount;
        }
    }
}