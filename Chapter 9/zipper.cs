/* Create:

string[] questions = { "Capital of Japan?", "2 + 2?", "Best coding language?" };

string[] answers = { "Tokyo", "4", "C#" };

Zip: Combine them into a single string format: "Question: [Q] | Answer: [A]".

Print: Loop through the zipped list and print the results. */

using System;

class Program
{
	static void Main()
	{
		string[] questions = ["Capital of Japan?", "2 + 2?", "Best coding language?"] ;

        string[] answers = ["Tokyo", "4", "C#" ];

        var combined = questions.Zip(answers, (q, a) => $"Question: {q} | Answer : {a}");

        foreach(string c in combined)
        {
            Console.WriteLine(c);
        }

	}
}