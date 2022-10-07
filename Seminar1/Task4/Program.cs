int a, b, c;
Console.WriteLine("Введите 3 числа:");
int.TryParse(Console.ReadLine()!, out a);
int.TryParse(Console.ReadLine()!, out b);
int.TryParse(Console.ReadLine()!, out c);
int max = a;
if (b > a)
    max = b;
if (c > max)
    max = c;
Console.WriteLine("Наибольшее число: {0}\n", max);
Console.ReadLine();