int number = 0, N = 2;
bool flag = true;
string summa = "", temp = "";

while (flag)
{
    Console.Write($"Введите число: ");
    string str = Console.ReadLine();


    if (Proverka(str) == "Число")
    {
        number = int.Parse(str);
        while (N <= number)
        {
            if ((N % 2) == 0)
            {
                temp = Convert.ToString(N);
                summa = summa + $"{temp},";
                
            }
            N++;
        }
        flag = false;
        Console.WriteLine($"{number} -> {summa}");
    }
    else
    {
        Console.Clear();
    }
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

