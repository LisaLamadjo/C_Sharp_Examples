// выводит третью цифру числа либо пишет что её нет

int num = int.Parse(Console.ReadLine()!);
void ThirdNum(int num)
{
    Console.Write($"{num} -> ");
    if (num < 100)
    {
        Console.WriteLine("Нет третьей цифры");
        return;
    }
    while (num > 999) num = num / 10;
    Console.WriteLine(num % 10);
}
int result = num % 10;
Console.WriteLine(result);
