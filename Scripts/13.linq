<Query Kind="Statements" />



        //method 1
		Dictionary<int, string> employees = new();

		employees.Add(1, "Shah");
		employees.Add(2, "Nawf");
		employees.Add(3, "Khadhija");
		employees.Add(4, "Dhanusri");

		foreach (KeyValuePair<int, string> entry in employees){
			Console.WriteLine($"Employee id : {entry.Key}\nName : {entry.Value}\n\n");
		}
        //method 2 - simple one
        Dictionary<string, int> items = new()
        {
            {"Apple", 50},
            {"Banana", 30},
            {"Orange", 20},
            {"Mango", 40}  

        };
		//lookup
		Console.WriteLine(items["Apple"] + "\n");
		foreach (KeyValuePair<string, int> entry in items){
			Console.WriteLine($"Furit : {entry.Key}\nPrice : Rs.{entry.Value}\n\n");
		}
		
		//safe look up
		if (employees.TryGetValue(999, out string result)){
			Console.WriteLine(result);
		}
		else
		{
			Console.WriteLine("Not Found!");
		}