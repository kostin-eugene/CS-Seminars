int m, n;
Console.Write("Введите число M: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write("Введите число N: ");
int.TryParse(Console.ReadLine()!, out n);

SumMtoN(m, n);

void SumMtoN(int m, int n)
{
    Console.Write(SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}