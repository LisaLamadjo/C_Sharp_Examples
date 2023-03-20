// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void NumbersFive(int a)
{
    int num_1 = a / 10000;
    int num_2 = a / 1000;
    int num_3 = a % 100;
    int num_4 = a % 10;

    if ((num_1 == num_4) || (num_2 == num_3))
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("Не является");
    }
}

int x = int.Parse(Console.ReadLine()!);
NumbersFive(x);