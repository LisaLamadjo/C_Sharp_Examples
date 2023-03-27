// найдите сумму элементов стоящих на нечётных позициях (чётные индексы)

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

int Sum(int [] array_1)
{
   int summ = 0;
    for (int i = 0; i < array_1.Length; i = i + 2)
    {
        
       summ += array_1[i];
       
    }
    return summ;
}

Console.WriteLine("Введите длину массива");
int le = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапазон чисел массива. От числа: ");
int sta = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапазон чисел массива. До числа: ");
int sto = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[] array = GenerateArray(le, sta, sto);
PrintArray(array);

Console.WriteLine("сумма элементов стоящих на нечётных позициях:");
Console.WriteLine(Sum(array));