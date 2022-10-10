int dayNumber;
int.TryParse(Console.ReadLine()!, out dayNumber);
if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("этот день выходной");
}
else if (dayNumber < 1 || dayNumber > 7)
{
    Console.WriteLine("Вводить нужно от 1 до 7");
}
else Console.WriteLine("этот день не выходной");

