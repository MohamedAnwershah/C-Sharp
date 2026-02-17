<Query Kind="Statements" />

int result = Calculator.Add(1, 5); // 1 + 5 = 6
Console.WriteLine(result);

class Calculator {

	public static int Add(int a, int b){
		return a + b;
	}
	
	public static int Subtract(int a, int b){
		return a - b;
	}
	
	public static int Multiply(int a, int b){
		return a * b;
	}
	
	public static float Divide(int a, int b){
		return a / b;
	}
}