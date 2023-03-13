// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

string n_a = Console.ReadLine()!;
string n_b = Console.ReadLine()!;

int a = int.Parse(n_a);
int b = int.Parse(n_b);

if (a > b)
{
    Console.WriteLine($"number {a} is greater, than {b}");
}
else if (a == b)
{
    Console.WriteLine("the same");
}
else
{
    Console.WriteLine($"number {b} is greater, than {a}");
}

