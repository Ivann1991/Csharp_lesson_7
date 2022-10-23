// Задайте двумерный массив. Найдите элементы массива, у которых оба индекса четные, и замените эти элементы на их квадраты.
Console.Clear();
Console.Write("Введи количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введи количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int [,] array = getArray(rows, columns, 0, 10);
printArray(array);
int [,] newarray = findEvenElement(array);
Console.WriteLine("Преобразованный массив");
printArray(newarray);


//////////////////////////////////
int [,] getArray(int m, int n, int minValue, int maxValue)        //////////заполнение двухмерного массива случайными числами.
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
int [,] findEvenElement (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (i%2 == 0 && j%2 == 0)
                array[i, j] = array[i, j] * array[i, j];
        }
    }
    return array;
}
void printArray (int [,] array)                                    ///////////вывод двухмерного массива
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