// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// 20 мин
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

Console.Clear();
var array = SetArray(5, 3, 0, 9);
PrintMatrix(array);
Console.WriteLine();
var sum = GetSum(array);
Console.WriteLine("Сумма элементов главной диагонали равна: " + sum);

sum = GetSumOpt(array);
Console.WriteLine("Сумма элементов главной диагонали равна(оптимизированный алгоритм): " + sum);



int GetSum(int[,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i == j)
                sum += arr[i,j];
        }
    }
    return sum;
}

int GetSumOpt(int[,] arr)
{
    int sum = 0;
    int length = 0;
    if(arr.GetLength(0) >= arr.GetLength(1))
        length = arr.GetLength(1);
    else
        length = arr.GetLength(0);
    for (int j = 0; j < length; j++)
    {
        sum += arr[j,j];
    }
    
    return sum;
}

int[,] SetArray(int rows, int columns, int min, int max)
{
    var array = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 3},");
            else Console.Write($"{array[i,j], 3}]");
        }
        Console.WriteLine();
    }
}