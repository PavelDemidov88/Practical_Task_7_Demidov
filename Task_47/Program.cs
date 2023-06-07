// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Write("Введите колличество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();

double[,] arr = new double[rows, columns];
Random random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        arr[i, j] = random.NextDouble() * 100; 
        Console.Write("{0,6:F2}", arr[i, j]);
    }
    Console.WriteLine();
}