// На вход принимает трёхзначное число и на выходе показывает вторую цифру этого числа

int num = int.Parse(Console.ReadLine()!);

if ((-1000 < num && num < -100) || (num < 1000 && num > 100))
{
    int result = num / 10 % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Число не трёхзначное");
}
