

int count = 1;
int a = 0, b = 0, c= 0, max = 0;

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
            count++;
        }
        else
        {
            Console.Clear();
        }
    }
    else if (count == 3)
    {
        if (Proverka(str) == "Число")
        {
            c = int.Parse(str);
            flag = false;
            max = a;
        }
        else
        {
            Console.Clear();
        }
    }
}
if (max < b)
{
    max = b;
    // Console.Write($"max = {a}");
}
if (max < c)

{
    max = c;

}

Console.Write($"{a} {b} {c} -> {max}");


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
