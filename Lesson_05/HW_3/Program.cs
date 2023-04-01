// Массив вещественных чисел. Найти разницу между максимальным
// и минимальным элементом массива

double[] GenerateArray(int len, double start, double stop)
{
    double[] arr = new double[len];
    Random n_new = new Random();

    for (int i = 0; i < len; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (stop - start) + start, 2);
    }
    return arr;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
     Console.WriteLine($"{array[array.Length - 1]}");
}

void MaxAndMin (double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
    
        if (max < arr[i]) max = arr[i];
        else if (min > arr[i]) min = arr[i]; 
    }

Console.WriteLine($"Max: {max}, Min: {min}");
Console.WriteLine($"Вычтание {max} - ({min}) = {Math.Round(max - min, 2)}");
}



Console.WriteLine("Введите длину массива");
int le = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапазон чисел массива. От числа: ");
double sta = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите диапазон чисел массива. До числа: ");
double sto = double.Parse(Console.ReadLine()!);
Console.WriteLine();
double[] array = GenerateArray(le, sta, sto);
PrintArray(array);
MaxAndMin(array);
