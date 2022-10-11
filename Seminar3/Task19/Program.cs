int n;
int.TryParse(Console.ReadLine()!, out n);
static bool palindrome(int n)
{
    int r = 0, nn = n;
    while (n > 0)
    {
        r = r * 10 + n % 10;
        n = n / 10;
    }
    return r == nn;
}
if (palindrome(n))
    Console.WriteLine($"Число является полиндромом");
else
    Console.WriteLine($"Число не является полиндромом");