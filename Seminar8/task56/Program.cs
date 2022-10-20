const int m = 3, n = 4;
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

int k = 0, sum = 0;
for (int j = 0; j < array.GetLength(1); j++)
    sum += array[0, j];
for (int i = 0; i < array.GetLength(0); i++)
{
    int tsum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        tsum += array[i, j];
    if (tsum < sum)
    {
        sum = tsum;
        k = i;
    }
}
Console.Write($"строка {k}, sum = {sum}");

