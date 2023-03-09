// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Write the first nuber: ");

int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Write the second nuber: ");

int b = int.Parse(Console.ReadLine()!);

if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}
if (a == b)
{
    Console.WriteLine("the same");
}

