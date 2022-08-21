string Proverka(string str)
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

bool flag = true;
while (flag)
{
    Console.WriteLine("Введите число: ");
    string number = Console.ReadLine();
    int day_week = Convert.ToInt32(number);
    if ((Proverka(number) == "Число") || (day_week <= 7))
    {
        if (day_week == 6 || day_week == 7)
        {
            Console.WriteLine($"{day_week} -> да");
            flag = false;
        }
        else
        {
            Console.WriteLine($"{day_week} -> нет");
            flag = false;
        }
    }
    else
    {
        Console.Clear();
    }
}



