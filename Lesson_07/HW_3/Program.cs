﻿// Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);
    return arr;
}

//выводящая функция
void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
            Console.WriteLine();
        }
    Console.WriteLine();
}



double Sum(int[,] arr, int row, int colum)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    double summ = 0;

    for (int j = 0; j < column_size; j++)
    {
        for (int i = 0; i < row_size; i++)
        {
            summ += arr[i,j];
        }
        summ/= row;
       Console.Write($"|{summ}| ");
       summ = 0;
    }
       return summ;
}






Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
Sum(mass, row_num, column_num);