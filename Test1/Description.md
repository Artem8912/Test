## Программа для вывода строк из строкового массива

**Создаём пользовательский ввод**

1. *Выводим сообщение с требованием ввести число элементов массива строк*
2. *Вводим с клавиатуры кол-во элементов и присваиваем его переменной **n***
Console.WriteLine("Введите число элементов");
int n = Convert.ToInt32(Console.ReadLine());

**Создаём строковый массив размерности n**
string[] array = new string[n];
**Создаём метод, заполняющий массив строками, которые вводятся с клавиатуры**

string[] FillArray(string[] arr)/ *Метод возвращает строковый массив*
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите строку №{i+1}:");
        arr[i] = Console.ReadLine();
    }
    return arr;
}
**Создаём метод, который выводит исходный массив на экран**
string[] PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    return arr;
}
**Создаём метод, который выводит на экран новый массив строк, длины которых не превышают 3 символов**
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
**Сохраняем в переменную result1 исходный массив, вводимый с клавиатуры**
string[] result1 = FillArray(array);
Console.WriteLine ("Исходный массив: ");
**Выводим исходный масссив на экран и сохраняем его в переменную result2**
string[] result2 = PrintArray(result1);
Console.WriteLine();
**Выводим новый массив строк, передавая исходный массив методу CreateNewArray**
Console.WriteLine ("Новый массив: ");
CreateNewArray(result2);



