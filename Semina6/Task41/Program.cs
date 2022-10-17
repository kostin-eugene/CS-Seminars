
//Сам не смог решить до конца, в самом начале не смог придумать как должны вводиться данные: через запятую, пробел или еще как-нибудь. Смотрел решение на семинаре. Очень круто!
List<string> list = new List<string>();

string user = Console.ReadLine()!;
user += " ";
string temp = "";

for (int i = 0; i < user.Length; i++)
{
    if (user[i] == '-' && IsDigit(user[i + 1]) && i < user.Length - 1)
    {
        if (temp != "")
        {
            list.Add(temp);
            temp = "-";
        }
        else
            temp = "-";
    }
    else if (IsDigit(user[i]))
    {
        temp += user[i];
    }
    else
    {
        if (temp != "")
        {
            list.Add(temp);
            temp = "";
        }
    }
}

int k = 0;

foreach (var item in list)
{
    if (int.Parse(item) > 0)
        k++;
}


foreach (var item in list)
    Console.Write($"{item} ");
Console.Write($"-> {k}");

bool IsDigit(char _ch)
{
    if (_ch >= '0' && _ch <= '9')
        return true;
    return false;
}