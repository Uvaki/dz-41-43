
// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



int[] a = new int[10];
Console.WriteLine("Введите 10 чисел.");
for (int i = 0; i < a.Length; i++)
{
    Console.Write($"Введите a[{i}]: ");
    a[i] = int.Parse(Console.ReadLine()); 
}
int sum = 0;
sum = sum + 3;
sum += 3;
for (int i = 0; i < a.Length; i++)
{
    sum += a[i];
}
Console.WriteLine($"Сумма 10 элементов массива: {sum}");




