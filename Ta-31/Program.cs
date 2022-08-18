int[] array = GetRandomArray(12);
WriteArrayToConsole(array);

int[] GetRandomArray(int arrayLength)
{
    Random rnd = new Random();
    int[] arr = new int[arrayLength];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0,2);
    }
    return arr;
}

void WriteArrayToConsole(int[] array)
{
    Console.Clear();
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i != array.Length -1)
            Console.Write(",");
    }
    Console.WriteLine("]");    
}
