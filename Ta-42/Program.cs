// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

//int UserInputInt(string userInputStr)
// {
    // Console.WriteLine(userInputStr);
    // int number = Convert.ToInt32(Console.ReadLine());
    // return number;
// }

// int first = UserInputInt ("Введите  длину  стороны  А");
// int second = UserInputInt ("Введите  длину  стороны  B");
// int thrind = UserInputInt ("Введите  длину  стороны  C");
// CheckTriangle(first,second,thrind);

// void CheckTriangle(int a, int b, int c)
// {
    // if (a < b + c && b < a + c && c < b + a) Console.WriteLine("Такоцй треугольник существует");
    // else Console.WriteLine(" Такого треугольника нет ");
// }


void ToBin (int n)
{
    if (n ==0 ) return;
    ToBin (n / 2);
    Console.Write (n % 2);
}

ToBin(123);



int[] Array = new int