//Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int CountNum()
{
    int count = 0;
    string word;

    while (true)
    {
        Console.WriteLine("Введите любое число: ");
        word = Console.ReadLine()!;

        if (word == "") return count;
        else if (int.Parse(word) > 0 ) count+=1;
    }
}

int count = CountNum ();
Console.WriteLine($"Numbers greater than zero: {count}");