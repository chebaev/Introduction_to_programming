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

void Sum_of_digits(int elem)
{
    int summa = 0;
    foreach (char c in Math.Abs(elem).ToString())
        summa += c - '0';
    Console.WriteLine($"{elem} -> {summa}");

}

int number = Proverka();
Sum_of_digits(number);




