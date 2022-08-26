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
int summa = 0;

foreach (char c in Math.Abs(number).ToString())
        summa += c - '0';
Console.WriteLine($"{number} -> {summa}");

