using System;

class Program
{
	static void Main()
	{
		string[] sentences = ["Hello World", "C# is fun", "LINQ is cool"];

        var splitSentences = sentences.SelectMany( s => s.Split(' '));

        foreach (string sentence in splitSentences)
        {
            Console.WriteLine(sentence);
        }


	}
}