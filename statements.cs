int x = 10; //declaration

if (x > 5) Console.WriteLine("Higher");
else Console.WriteLine("Lower"); //conditional statement


int age = 21; //switch case

switch (age) {

	case < 19: 
		Console.WriteLine("young");
		break;
	
	case >= 19 and <= 45: 
		Console.WriteLine("Adult");
		break;
	
	case > 45:
		Console.WriteLine("Senior Citizen");
		break;

}

//while
Console.WriteLine("\nWhile:");
while (x !=5 ) {
 Console.WriteLine(x);
 x--;
 
}

//do while
Console.WriteLine("\nDo While:");
do { 
 Console.WriteLine(x);
 x++;
} 
 while (x != 10);
 
//for
Console.WriteLine("\nFor:");
for (int i = 0; i < 10; i++){

 Console.WriteLine(i);
}

//foreach
Console.WriteLine("\nFor Each:");
string name = "Anwer";
foreach (char n in name.ToUpper()){
 Console.Write($"{n} ");
}