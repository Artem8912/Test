Console.WriteLine("Введите число элементов");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

string[] FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите строку №{i+1}:");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

string[] PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    return arr;
}

void CreateNewArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length<=3)
        {
            Console.Write($"{arr[i]} ");
        }
    }
}
string[] result1 = FillArray(array);
Console.WriteLine ("Исходный массив: ");
string[] result2 = PrintArray(result1);
Console.WriteLine();
Console.WriteLine ("Новый массив: ");
CreateNewArray(result2);



