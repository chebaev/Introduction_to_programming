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
        int num = Convert.ToInt32(number);

        if (num > 99 && num < 999)
        {
            Console.WriteLine($"{number} -> {num % 10}");

        }
        else if (num > 999)
        {
            Console.WriteLine($"{number} -> {(num / 100) % 10}");
        }

        else
        {
            Console.WriteLine($"{number} -> Третьей цифры нет");
        }
        flag = false;

    }
    else
    {
        Console.Clear();
    }

}



