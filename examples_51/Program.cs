// Задайте двумерный массив. Найдите сумму элементов массива, которые расположены на главной диагонали.
Console.Clear();
Console.Write("Введи количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введи количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = getArray(rows, columns, 0, 5);
printArray(array);
Console.WriteLine();
int sum = summaElementsMainDiagonal(array);
Console.Write($"сумма элементов главной диагонали массиа равна {sum}");


//////////////////////////////////
int[,] getArray(int m, int n, int minValue, int maxValue)        //////////заполнение двухмерного массива случайными числами.
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void printArray(int[,] array)                                    ///////////вывод двухмерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int summaElementsMainDiagonal(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i, j];
            }
        }

    }
    return sum;
}