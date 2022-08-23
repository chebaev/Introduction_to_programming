int Coup(int temp)
{
    int newNumber = 0;
    while (temp > 0)
    {
        int last = temp % 10;
        newNumber = newNumber * 10 + last;
        temp = temp / 10;
    }
    return newNumber;
}
int Proverka()
{
    int number;
    while (true)
    {
        Console.Write("Введите число: ");
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
int newNumber = Coup(number);

if (newNumber == number)
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}

