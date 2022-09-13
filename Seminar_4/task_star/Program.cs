
void Herringbone(int number)
{
    Console.WriteLine($"{number} -> ");
    for (int i = 0; i < number; i++)
    {
        for (int p = number; p > i; p--)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i * 2; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

int Proverka()
{
    int number;
    while (true)
    {
        Console.Write($"Введите число: ");
        string str = Console.ReadLine();

        try
        {
            number = Convert.ToInt32(str);
            return number;
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка! Неверное число. ");
        }
    }
}


int number = Proverka();
Console.WriteLine();
Herringbone(number);