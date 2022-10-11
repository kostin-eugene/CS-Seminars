int array;
Console.WriteLine("Введите длинну массива: ");
int.TryParse(Console.ReadLine()!, out array);
int[] randomArray = new int[array];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1, 9);
    Console.Write(randomArray[i] + " ");
}
