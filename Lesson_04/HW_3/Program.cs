//  Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран.
//Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)
//функция заполняющаяя
//функция выводящяя
int[] GenerateArray(int len, int start, int stop)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(start, stop);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
     Console.WriteLine($"{array[array.Length - 1]}");
}

Console.WriteLine("Введите длину массива");
int le = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапазон чисел массива. От числа: ");
int sta = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапазон чисел массива. До числа: ");
int sto = int.Parse(Console.ReadLine()!);

int[] array = GenerateArray(le, sta, sto);
PrintArray(array);

