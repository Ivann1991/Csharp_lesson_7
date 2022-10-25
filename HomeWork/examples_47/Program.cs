// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
Console.Write("Введи количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введи количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
double [,] array = getArray(rows, columns, -10, 10);
printArray (array);






//////////////////////////////////////////////
double [,] getArray(int m, int n, int minValue, int maxValue)        //////////заполнение двухмерного массива случайными числами.
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue) + Math.Round(new Random().NextDouble(), 2);
        }
    }
    return array;
}

void printArray (double [,] array)                                    ///////////вывод двухмерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array [i,j]} ");
        }
        Console.WriteLine();
    }
}
