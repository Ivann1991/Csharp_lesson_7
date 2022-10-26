// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
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
bool proverka(int a, int b, int[,] array)                         ///////////проверка на правилность ввода позиции элемента массива
{
    if (a < 1)
        return true;
    else if (a > array.GetLength(0))
        return true;
    else if (b < 1)
        return true;
    else if (b > array.GetLength(1))
        return true;
    else
        return false;    
}

Console.Clear();
int rows = new Random().Next(1, 11);
int columns = new Random().Next(1, 11);
int[,] array = getArray(rows, columns);
printArray(array);
Console.Write($"Введи номер строки элемента массива от 1 до {rows}: ");
int a = int.Parse(Console.ReadLine() ?? "");
Console.Write($"Введи номер столбца элемента массива от 1 до {columns}: ");
int b = int.Parse(Console.ReadLine() ?? "");
bool result = proverka(a, b, array);
if (result)
    Console.WriteLine("Элемента с таким номером строки или столбца не существует");
else 
    Console.WriteLine($"Выбранный элемент массива это {array[a - 1, b - 1]}");            