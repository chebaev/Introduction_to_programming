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

    if (Proverka(number) == "Число")
    {
        if (number.Length > 2)
        {
            Console.WriteLine($"{number} -> {number[2]}");
            flag = false;
        }
        else
        {
            Console.WriteLine($"{number} -> Третьей цифры нет");
            flag = false;
        }


    }
    else
    {
        Console.Clear();
    }

}



