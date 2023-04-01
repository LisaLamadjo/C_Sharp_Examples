// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
//возвращает значение этого элемента или же указание, что такого элемента нет.


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


//ищем по координатам число
string Find(int[,] mass, int a, int b)
{
    for (int i = 0; i < mass.GetLength(0) && i >= 0; i++)
    {
        for (int j = 0; j < mass.GetLength(1) && j >= 0; j++)
        {
            if (i == a-1 && j == b-1) return $"{mass [i,j]}";
        }
    }
    return "No";
}



Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the min number of massive ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive ");
int stop = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of rows of finding number: ");
int row_coord = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of colums of finding number:");
int colum_coord = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
Console.WriteLine(Find(mass, row_coord, colum_coord));
