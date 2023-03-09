// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих

Console.WriteLine("Write the first nuber: ");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Write the second nuber: ");

int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Write the third nuber: ");

int c = int.Parse(Console.ReadLine()!);

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.Write(max);