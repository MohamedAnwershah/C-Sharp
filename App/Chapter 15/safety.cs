using System;

class Program
{
    static void Main()
    {
        string path = "bad_text.txt";
        using (StreamWriter sw = new(path))
        {
            sw.WriteLine("Hello!");
        } //automatically closes the StreamWriter
        

        try
        {
            string text = File.ReadAllText(path);
            Console.WriteLine(text);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}