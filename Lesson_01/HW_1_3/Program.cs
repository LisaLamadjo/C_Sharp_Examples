//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("write a number: ");

int number = int.Parse(Console.ReadLine()!);

int result = number / 2;

if (result%2 == 0 )

{
    Console.WriteLine("Чётное");
}

else

{
    Console.WriteLine("Нечётное");
}


