MyClass A = new MyClass();
A.Value = 10;
MyClass B = A;
B.Value = 20;

MyStruct C = new MyStruct();
C.Value = 10;
MyStruct D = C;
D.Value = 20;

Console.WriteLine(A.Value); 
Console.WriteLine(C.Value);

class MyClass { public int Value; } //reference Type

struct MyStruct { public int Value; } //value Type

