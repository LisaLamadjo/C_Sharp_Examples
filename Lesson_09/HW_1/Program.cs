// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
//натуральные числа в промежутке от M до N с помощью рекурсии.  от 3(М) до 10(N)

Console.Write("Enter number M: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter number N: ");
int num2 = int.Parse(Console.ReadLine()!);

void NaturalArr(int M, int N)
{
if(M > N) return;

if (N % 2 == 0)
{
NaturalArr(M, N-2);
}

else 
{ 
N-=1;
NaturalArr(M, N-2);
}
Console.Write($"{N} ");

}

NaturalArr(num, num2);