int Proverka(string letter)
{
    int number;
    while (true)
    {
        Console.Write($"Введите число {letter}: ");
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


void Temp(int A, int B)
{
    for (int i = 0; i < B; i++)
    {
        summa = summa * A;
    }
    Console.WriteLine($"{A}, {B} -> {summa}");
}

int A = Proverka("A");
int B = Proverka("B");
int summa = 1;
Console.WriteLine($"Проверка = {Math.Pow(A, B)}");

Temp(A, B);