//int number = ReadInt("Введите число N: ");
int N;
Console.WriteLine("Введите число N: ");
int.TryParse(Console.ReadLine()!, out N);
for (int i = 1; i <= N; i++)
{
    Console.Write($"{i * i * i} ");
}
