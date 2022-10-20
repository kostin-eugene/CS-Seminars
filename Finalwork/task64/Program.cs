int n, count;
Console.Write("Введите число N: ");
int.TryParse(Console.ReadLine()!, out n);
count = 1;
NaturalToLow(n, count);


void NaturalToLow(int num, int count)
{
    if (count > num)
    {
        return;
    }
    else
    {
        NaturalToLow(num, count + 1);
        Console.Write(count + " ");
    }
}