
/* Change your Main method to be async Task.

Create an HttpClient.

Use .GetStringAsync() to download a website.

Print the size of the downloaded text. */


using System;

class Program
{
	static async Task Main()
	{
		using HttpClient client = new();

        string url = "https://zenbridge.io";
        try
        {
            var response = await client.GetStringAsync(url);
            // string content = await response.Content.ReadAsStringAsync(); //can be used when using GetAsyn() method :)
            Console.WriteLine(response[..110]);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error : {ex.Message}");
        }
	}
}