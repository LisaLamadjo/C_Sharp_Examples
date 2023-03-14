// выводит случайное трёхзначное число и удаляет вторую цифру числа

int num = new Random().Next(100,1000);
Console.WriteLine(num);

int PartNumber1 = num % 10;
int PartNumber2 = num / 100;

int a = PartNumber2 * 10;
int result = a + PartNumber1;

Console.WriteLine(result);
