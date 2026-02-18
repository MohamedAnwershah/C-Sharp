using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Unicode;

class Program
{
    static void Main()
    {
        string path = "Bytes.dat";

        string message = "Hello";

        byte[] byteData = Encoding.UTF8.GetBytes(message);

        foreach(var i in byteData)
        {
            Console.WriteLine(i);
        }

        using FileStream fs = new(path, FileMode.Create);
        fs.Write(byteData, 0, byteData.Length);
    }
}