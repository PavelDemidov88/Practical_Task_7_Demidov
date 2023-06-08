// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine();
int[,] array = GetArray(4, 4, 0, 9);
PrintArray(array);
Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
ArithmeticMean(array);
Console.WriteLine();

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0; j<columns; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i=0; i<inArray.GetLength(0); i++)
    {
        for(int j=0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] arr)
{
    for(int i=0; i<arr.GetLength(1); i++)
    {
        int sum = 0;
        for(int j=0; j<arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        double a = sum;
        
        Console.Write($"({a/arr.GetLength(0)}) ");
    }
}