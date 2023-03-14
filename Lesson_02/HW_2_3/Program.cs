// выводит третью цифру числа либо пишет что её нет

int num = int.Parse(Console.ReadLine()!);

if (num < 100)
{
    Console.WriteLine("Нет третьей цифры");

}
else
{
    while (num > 999)
    { num = num / 10;
    return;} 
}
int result = num % 10;
Console.WriteLine(result);
