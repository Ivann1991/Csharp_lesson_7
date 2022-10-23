// Задайте двумерный массив m x n, каждый элемент в массиве находится по формуле Aij = i+j. вывести полученный массив
Console.Clear();
Console.Write("Введи количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введи количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int [,] array = getArray(rows, columns);
printArray (array);


///////////////////////////////////////////////////////////
int [,] getArray(int m, int n)        //////////заполнение двухмерного массива по формуле
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
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