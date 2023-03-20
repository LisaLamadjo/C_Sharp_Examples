// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNum(int num)
{
   int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num = num / 10;
        
    }
    return sum;
}

int number = int.Parse(Console.ReadLine()!);
int result = SumNum(number);
Console.WriteLine(result);