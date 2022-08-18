// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int[] CreateArrayRndInd (int size, int min, int max) // 1 пункт
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
} 

int SumElements (int[] array)
{   
    int sumElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            sumElements = sumElements + 1;
        }
    }
    return sumElements;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i] + "]");
    }
}

int[] array = CreateArrayRndInd(15, 0, 123);
PrintArray(array);
int res = SumElements(array);
Console.WriteLine(" ");
Console.WriteLine($"{res}");
