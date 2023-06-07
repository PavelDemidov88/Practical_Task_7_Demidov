// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

///1 4 7 2
//5 9 2 3
//8 4 2 4
//[1,7] -> такого числа в массиве нет
int[,] array = GetArray(9, 9, 0, 9);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Задайте строку: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте столбец: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine();
FindValue(array, a, b);
Console.WriteLine();

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows,columns];
    for(int i=0; i<rows; i++)
    {
        for(int j=0;j<columns; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue+1);
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
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FindValue(int[,] arr, int a, int b)
{
    if( a<arr.GetLength(0)+1 & b<arr.GetLength(1)+1)
    
        Console.WriteLine("Эта ячейка содержит: " +arr[a-1, b-1]);
    
    else
        Console.WriteLine("Такого числа в массиве нету!");
    
}