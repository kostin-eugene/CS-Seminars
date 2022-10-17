double b1, b2, k1, k2;
Console.WriteLine("введите значение b1");
double.TryParse(Console.ReadLine()!, out b1);
Console.WriteLine("введите число k1");
double.TryParse(Console.ReadLine()!, out k1);
Console.WriteLine("введите значение b2");
double.TryParse(Console.ReadLine()!, out b2);
Console.WriteLine("введите число k2");
double.TryParse(Console.ReadLine()!, out k2);

double X = (b2 - b1) / (k1 - k2);
double Y = k2 * X + b2;

Console.WriteLine($"Точка пересечения двух прямых: {X},{Y}");