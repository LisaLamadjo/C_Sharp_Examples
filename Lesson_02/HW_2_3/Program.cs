// выводит третью цифру числа либо пишет что её нет

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
int number = int.Parse(Console.ReadLine()!);
ThirdNum(number);
