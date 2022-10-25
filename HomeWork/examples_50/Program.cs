// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
int rows = new Random().Next(1, 11);
int columns = new Random().Next(1, 11);
int[,] array = getArray(rows, columns);
printArray(array);
Console.Write($"Введи номер строки элемента массива от 1 до {rows}: ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.Write($"Введи номер столбца элемента массива от 1 до {columns}: ");
int b = int.Parse(Console.ReadLine() ?? "");
if (a < 1)
    Console.WriteLine("Строки с таким номером не существует");
else if (a > array.GetLength(0))
        Console.WriteLine("Строки с таким номером не существует");
else if (b < 1)
        Console.WriteLine("Столбца с таким номером не существует");
else if (b > array.GetLength(1))
        Console.WriteLine("Столбца с таким номером не существует");
else                          
Console.WriteLine(array[a-1, b-1]);


//////////////////////////////////////////////
int[,] getArray(int m, int n)        //////////заполнение двухмерного массива случайными числами.
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 100);
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
