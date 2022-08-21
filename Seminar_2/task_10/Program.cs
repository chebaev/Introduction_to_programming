

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
    Console.WriteLine("Введите трёхзначное число: ");
    string number = Console.ReadLine();

    if (Proverka(number) == "Число")
    {

        Console.WriteLine($"{number} -> {number[1]}");
        flag = false;
    }
    else
    {
        Console.Clear();
    }

}



