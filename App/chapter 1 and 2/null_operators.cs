string s = null;
Console.WriteLine(s ?? "Hi"); //if null gives the right value

string a = null;
Console.WriteLine(a);
a ??= "hello";  //assign if null
Console.WriteLine(a);

StringBuilder sb = null;
int? length = sb?.Length; //checks if null before giving error

