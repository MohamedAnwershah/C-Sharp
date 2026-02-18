using System;

class Program
{
	static void Main()
	{
		Dictionary<string, List<decimal>> gradeBook = [];
        gradeBook.Add("Alice", [85, 92, 88]);
        gradeBook.Add("Bob", [70, 65, 75]);
        gradeBook.Add("Charlie", [95, 98, 92]);

        List<StudentResult> finalResult = [];
        foreach (var data in gradeBook)
        {
            decimal avg = data.Value.Sum() / data.Value.Count;
            finalResult.Add(new StudentResult(data.Key, avg));

        }
        finalResult.Sort();
        foreach (var value in finalResult)
        {
            Console.WriteLine($"Name : {value.Name}. Average : {value.Score:F2}");
        }	
    }

}

class StudentResult (string name, decimal score) : IComparable<StudentResult>
{
    public string Name = name;
    public decimal Score = score;

    public int CompareTo(StudentResult? other)
    {
        if (other is null)
        {
            return 0;
        }
        return other.Score.CompareTo(this.Score);
    }
}