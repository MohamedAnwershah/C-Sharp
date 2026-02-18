using System;
using System.IO.Compression;
using System.Text;
using System.Xml;

class Program
{
    static void Main()
    {
        string normalPath = "noraml.txt";
        string compressedPath = "compressed.txt";

        string data = new('A', 100000);

        byte[] byteData = Encoding.UTF8.GetBytes(data);
        File.WriteAllBytes(normalPath, byteData);
        using (FileStream fs = new(compressedPath, FileMode.Create))
        {
            using (GZipStream gs = new(fs, CompressionMode.Compress))
            {
                gs.Write(byteData, 0, byteData.Length);
            }
        };

        long normalSize = new FileInfo(normalPath).Length;
        long compressedSize = new FileInfo(compressedPath).Length;

        Console.WriteLine($"Normal file : {normalSize:N0}\nCompressed file : {compressedSize:N0}");


    }
}