// задайте массив заполненный случайными трёхзнач цислами
//программа покажет кол-во чётных чисел в массиве

int[] GenerateArray(int len)
{
   
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(100, 1000);
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

int AmoutEvenNum(int[] arr)
{
    int num = 0;
     for (int i = 0; i < arr.Length; i++)
     {
        if (arr[i] % 2 == 0)
          num++;
     }
     return num;
}


Console.WriteLine("Введите длину массива");
int le = int.Parse(Console.ReadLine()!);
Console.WriteLine();

Console.WriteLine("Массив:");
int[] array = GenerateArray(le);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Кол-во чётных чисел:");
Console.WriteLine(AmoutEvenNum(array));