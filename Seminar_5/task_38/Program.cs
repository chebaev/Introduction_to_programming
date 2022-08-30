int Proverka()
{
    int number;
    while (true)
    {
        Console.Write($"Введите размер массива: ");
        string str = Console.ReadLine();

        try
        {
            number = Convert.ToInt32(str);
            return number;
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка! Неверное число. Попробуйте ещё раз только цифры. ");
            Console.WriteLine();
        }
    }
}
double SumOfElements(double[] temp)
{
    double max = temp[0];
    double min = temp[0];

    for (int i = 1; i < temp.Length; i++)
    {
        if (temp[i] < min)
        {
            min = temp[i];
        }
    }
    for (int i = 1; i < temp.Length; i++)
    {
        if (temp[i] > max)
        {
            max = temp[i];
        }
    }
    return (max - min);
}

double[] CreateArray(int number)
{

    double[] array = new double[number];
    for (int i = 0; i < number; i++)
    {

        array[i] = new Random().Next(1, 101);

    }
    return array;
}

int num = Proverka();

double[] array = CreateArray(num);
Console.WriteLine($"[{string.Join(", ", array)}]  -> {SumOfElements(array)}");




