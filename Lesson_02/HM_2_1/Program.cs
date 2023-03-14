// На вход принимает трёхзначное число и на выходе показывает вторую цифру этого числа

int num = int.Parse(Console.ReadLine()!);

int result1 = num / 10 ;
int result2 = result1 % 10;

Console.WriteLine(result2);