// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Clear();

Console.WriteLine($"Задача 41. Cколько чисел больше 0 ввёл пользователь ");
Console.Write($"Введи число X(количество чисел): ");
int x = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[x];

void InputNumbers(int x)
{
    for (int i = 0; i < x; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int Comparison(int[] massiveNumbers)
{
    int count = 0;
    for (int i = 0; i < massiveNumbers.Length; i++)
    {
        if (massiveNumbers[i] > 0) count += 1;
    }
    return count;
}

InputNumbers(x);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");
