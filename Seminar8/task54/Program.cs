int m, n, r;
Console.WriteLine("Введите количество столбцов:");
int.TryParse(Console.ReadLine()!, out m);
Console.WriteLine("Введите количество строк:");
int.TryParse(Console.ReadLine()!, out n);
Console.WriteLine("Введите диапозон значений элементов:");
int.TryParse(Console.ReadLine()!, out r);
Console.WriteLine();
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

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int k = 0; k < array.GetLength(1) - 1; k++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                int temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }
        }
    }
}
Console.WriteLine("\nОтсортированный массив:\n");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]} ");
    Console.WriteLine();
}



