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

int N = Proverka();


int count = 1;
string temp = " ";
while (count <= N)
{
    if (temp == " ")
    {
        temp = Convert.ToString(Math.Pow(count, 3));
    }
    else
    {
        temp = temp + ", " + Math.Pow(count, 3);
    }
    count++;
}

Console.WriteLine($"{N} ->  {temp} ");