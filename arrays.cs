
char[] vowels = {'a','e','i','o','u'}; //simple array

int[,] rect = {
	{1,2,3},
	{4,5,6},
	{7,8,9}
}; //rectangular matrix

int[][] jagged = {
	new int[] {1,2,3},
	new int[] {4,5,6,7},
	new int[] {8,9,0}

}; //jagged matrix

Console.WriteLine(vowels);
Console.WriteLine(rect);
Console.WriteLine(jagged);

//prints jagged array
for (int i=0; i<jagged.Length; i++){
    Console.WriteLine($"Row {i} : ");
    for (int j=0; j<jagged[i].Length; j++){ 
        Console.Write($"{jagged[i][j]} ");
    }
    Console.WriteLine();
}

//prints rectangular array
for (int i=0; i<rect.GetLength(0); i++){
    Console.WriteLine($"Row {i} : ");
    for (int j=0; j<rect.GetLength(1); j++){ 
        Console.Write($"{rect[i,j]} ");
    }
    Console.WriteLine();
}

//prints simple array
for (int i=0; i<vowels.Length; i++){
    Console.Write($"{vowels[i]} ");
}

