

int count = 1;
int a = 0, b = 0;

bool flag = true;
while (flag)
{
    Console.Write($"Введите {count} число: ");
    string str = Console.ReadLine();

    if (count == 1)
    {
        if (Proverka(str) == "Число")
        {
            a = int.Parse(str);
            count++;
        }
        else
        {
            Console.Clear();
        }
    }
    else if (count == 2)
    {
        if (Proverka(str) == "Число")
        {
            b = int.Parse(str);
            flag = false;
        }
        else
        {
            Console.Clear();
        }
    }
}
if (a > b)
{
    Console.Write($"max = {a}");
}
else
{
    Console.Write($"max = {b}");
}


static string Proverka(string str)
{
    try
    {
        Convert.ToInt32(str);
        return "Число";
    }
    catch (Exception)
    {
        return "Не число";
    }

}
