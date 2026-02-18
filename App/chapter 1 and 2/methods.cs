
public class methods {
    public static void Main() {
        int sum = Calculator.Add(10, 5); // 10 + 5 = 15
        Console.WriteLine($"Sum: {sum}");

        int difference = Calculator.Subtract(10, 5); // 10 - 5 = 5
        Console.WriteLine($"Difference: {difference}");

        int product = Calculator.Multiply(10, 5); // 10 * 5 = 50
        Console.WriteLine($"Product: {product}");

        float quotient = Calculator.Divide(10, 5); // 10 / 5 = 2
        Console.WriteLine($"Quotient: {quotient}");
    }
}


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