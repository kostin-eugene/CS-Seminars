int[,] A = new int[2, 2]
{
    {2, 4},
    {3, 2}
};
int[,] B = new int[2, 2]
{
    {3, 4},
    {3, 3}
};

if (A.GetLength(1) != B.GetLength(0))
{
    Console.Write($"Произведение матриц невозможно из-за несоответствия размеров");
    return;
}


int[,] C = new int[A.GetLength(0), B.GetLength(1)];


for (int i = 0; i < C.GetLength(0); i++)
{
    for (int j = 0; j < C.GetLength(1); j++)
    {
        for (int k = 0; k < A.GetLength(1); k++)
        {
            C[i, j] += A[i, k] * B[k, j];
        }
    }
}

for (int i = 0; i < C.GetLength(0); i++)
{
    for (int j = 0; j < C.GetLength(1); j++)
        Console.Write($"{C[i, j]} ");
    Console.WriteLine();
}