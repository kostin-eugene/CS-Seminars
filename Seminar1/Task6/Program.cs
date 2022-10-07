int a;

Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

if (a % 2 == 0)
{
    Console.Write("Число четное");
}
else
{
    Console.Write("Число нечетное");
}