// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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
void srArif(int[,] array)                                         ////// нахождение среднего арифметического элементов столбцов
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            count += 1;
        }
        Console.Write($"\nСреднее арифметическое элементов {j + 1} столбца равно {Math.Round(sum / count, 2)} ");
    }

}
Console.Clear();
Console.Write("Введи количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введи количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = getArray(rows, columns, 0, 10);
printArray(array);
srArif(array);
