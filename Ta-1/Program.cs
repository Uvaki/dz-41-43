// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int num1;
int num2;
int max;
int min;
Console.WriteLine("Введите целое число");
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
    {
       max = num1;
       min = num2;
    }
else 
    {
       max = num2;
       min = num1;
    }
Console.WriteLine($"меньшее число {min}");
Console.WriteLine($"большее число {max}");