int n;
Console.WriteLine("Введите число N:");
int.TryParse(Console.ReadLine()!, out n);
int i = 1;
while (i <= n)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
    }
    i++;
}

