int m, n;
Console.Write("Введите число M: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write("Введите число N: ");
int.TryParse(Console.ReadLine()!, out n);
AkkrmnFunc(m, n);
int Akkrmn(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkrmn(m - 1, 1);
    }
    else
    {
        return (Akkrmn(m - 1, Akkrmn(m, n - 1)));
    }
}
void AkkrmnFunc(int m, int n)
{
    Console.Write(Akkrmn(m, n));
}

