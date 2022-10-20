int[,,] array = new int[2, 2, 2];
FillArray(array);
PrintIndex(array);

void PrintIndex(int[,,] _array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] _array)
{
    int count = 10;
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            for (int k = 0; k < _array.GetLength(2); k++)
            {
                _array[k, i, j] += count;
                count += 3;
            }
        }

    }
}