using System;

class Program
{
	static void Main()
	{
		TimeZoneInfo utc = TimeZoneInfo.FindSystemTimeZoneById("UTC");
        
        TimeZoneInfo jst = TimeZoneInfo.FindSystemTimeZoneById("Asia/Tokyo");
        TimeZoneInfo est = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
        DateTime dt = new(2026, 2, 10, 15,0, 0);
        Console.WriteLine($"Eastern : {dt}");

        DateTimeOffset london = TimeZoneInfo.ConvertTime(dt,est, utc);
        DateTimeOffset japan = TimeZoneInfo.ConvertTime(dt,est, jst);

        Console.WriteLine($"London : {london}");
        Console.WriteLine($"Japan : {japan}");
        
	}

}
