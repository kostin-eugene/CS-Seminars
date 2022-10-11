int x1, x2, y1, y2, z1, z2;
Console.WriteLine("Введите координату X первой точки: ");
int.TryParse(Console.ReadLine()!, out x1);
Console.WriteLine("Введите координату Y первой точки: ");
int.TryParse(Console.ReadLine()!, out y1);
Console.WriteLine("Введите координату Z первой точки: ");
int.TryParse(Console.ReadLine()!, out z1);
Console.WriteLine("Введите координату X второй точки: ");
int.TryParse(Console.ReadLine()!, out x2);
Console.WriteLine("Введите координату Y второй точки: ");
int.TryParse(Console.ReadLine()!, out y2);
Console.WriteLine("Введите координату Z второй точки: ");
int.TryParse(Console.ReadLine()!, out z2);

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние между точками в 3D пространстве {length}");