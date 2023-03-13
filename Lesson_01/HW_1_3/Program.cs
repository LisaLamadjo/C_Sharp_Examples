//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным еven (делится ли оно на два без остатка) или нечётным odd

Console.WriteLine("write a number: ");

int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)

{
    Console.WriteLine($"The number {number} is even");
}

else

{
    Console.WriteLine($"The number {number} is odd");
}


