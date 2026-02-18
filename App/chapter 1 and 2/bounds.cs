int[] data = { 10, 20, 30 };
try
{
    int val = data[3];
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.Message);
}