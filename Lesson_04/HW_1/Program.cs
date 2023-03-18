//Напишите цикл, который принимает на вход
//два числа (A и B) и возводит число A в натуральную степень B.

int Stepen(int A, int B)
{
    int proiz = 1;
    for (int count = 0; count < B; count++)
    {
        proiz *= A;  
    
    }
    return proiz; 
}
int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);

int result = Stepen(num_1, num_2);
Console.WriteLine(result);

