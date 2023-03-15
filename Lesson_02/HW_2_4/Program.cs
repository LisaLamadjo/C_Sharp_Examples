// принимает на вход цифру обозначающую день недели и проверяет является ли этот день выходным
void Week(int num)
{
    string text = "not quite a week";

    if (num == 6 || num == 7) text = "weekend";
    else if ((num > 0) && (num < 6)) text = "workday";

    Console.WriteLine($"{num} -> {text}");
}

int a = int.Parse(Console.ReadLine()!);
Week(a);