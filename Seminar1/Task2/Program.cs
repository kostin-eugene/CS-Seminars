int a, b;
Console.WriteLine("Введите первое число:");
int.TryParse(Console.ReadLine()!, out a);
Console.WriteLine("Введите второе число:");
int.TryParse(Console.ReadLine()!, out b);
if (a > b)
    Console.WriteLine("max: {0}\n", a);
else
    Console.WriteLine("max: {0}\n", b);

