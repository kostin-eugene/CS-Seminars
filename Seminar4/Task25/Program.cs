int a, b;
int.TryParse(Console.ReadLine()!, out a);
int.TryParse(Console.ReadLine()!, out b);
pow(a, b);
void pow(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

