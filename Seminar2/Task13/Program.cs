int a;
int.TryParse(Console.ReadLine()!, out a);
int count = a.ToString().Length;
Console.Write(MakeArray(a, count));
int MakeArray(int a, int b)
{
    int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры не существует");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
    return result;
}
