// диагонали пересекаются или не пересекаются и в какой точке с координатами

void Inter (double k1, double b1, double k2, double b2)
{
    double k_sub = k1 - k2;
    if (k_sub != 0)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечкния ({x};{y})");
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("Множестве точек пересечения");
    else
        Console.WriteLine("Точки пересечения отсутствуют");
}       

Console.WriteLine("Введите значение k1:");
double k_1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение k2:");
double k_2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b1:");
double b_1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение b2:");
double b_2 = double.Parse(Console.ReadLine()!);

Inter (k_1, k_2, b_1, b_2);