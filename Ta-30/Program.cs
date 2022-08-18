int[] array = new int[20];

for (int i = 0; i < array.Length; i++)
{
    int num = new Random().Next(0, 2);
    array[i] = num;
}

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
}
Console.Write("]");

