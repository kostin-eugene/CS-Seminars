Console.WriteLine("Введите размер массива");
int size;
int.TryParse(Console.ReadLine()!, out size);
int[] numbers = new int[size];
int count = 0;
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
        count++;
}
Console.WriteLine($"количество чётных чисел в массиве: {count} ");
void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
