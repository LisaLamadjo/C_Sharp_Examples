// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

double[,] MassNums(int row, int column, double from, double to)
{   
    double[,] arr = new double[row, column];
    Random n_new = new Random();
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i,j] = Math.Round(n_new.NextDouble() * (to - from) + from, 1);
    return arr;
}

//выводящая функция
void Print(double[,] arr)
{
    double row_size = arr.GetLength(0);
    double column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
            Console.WriteLine();
        }
    Console.WriteLine();
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the min number of massive ");
double start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
double stop = int.Parse(Console.ReadLine()!);

double[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
