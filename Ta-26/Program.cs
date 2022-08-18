Console.Clear();
Console.WriteLine("Введи число:");
int a = Convert.ToInt32(Console.ReadLine());

int GetCountNum(int numb)
{
    int index = 1;
    int x = 0;
    while (index <= numb)
    {
        x = x + 1;
        index = index * 10;
    }
    return x;
}
int res = GetCountNum(a);
Console.WriteLine($"Количество цифр в числе = {res}");
