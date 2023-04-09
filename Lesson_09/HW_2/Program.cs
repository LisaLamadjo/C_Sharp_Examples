//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8 -> 30

Console.Write("Enter number M: ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Enter number N: ");
int num2 = int.Parse(Console.ReadLine()!);

int NaturalArr(int M, int N)
{
if(N+1 == M) return 0;
return N + NaturalArr(M, N-1);
}
Console.WriteLine(NaturalArr(num, num2));
