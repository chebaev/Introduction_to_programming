/// Функция Получение строки и проверка на число.
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

//Функция нахождения минимума в массиве
double MinArray(double[] arraymin)
{
    double min = arraymin[0];
    for (int i = 1; i < arraymin.Length; i++)
    {
        if (arraymin[i] < min)
        {
            min = arraymin[i];
        }
    }
    return min;
}

//Функция нахождения максимума в массиве
double MaxArray(double[] arraymax)
{
    double max = arraymax[0];
    for (int i = 1; i < arraymax.Length; i++)
    {
        if (arraymax[i] > max)
        {
            max = arraymax[i];
        }
    }
    return max;
}


/// Функция вычисляет разницу между максимальным и минимальным 
double SumDifference(double[] temp)
{
    double max = MaxArray(temp);
    double min = MinArray(temp);

    return (max - min);
}

/// Функция Формирование массива из вещественных чисел
double[] CreateArray(int number, int minValue, int maxValue)
{

    double[] array = new double[number];
    for (int i = 0; i < number; i++)
    {
        double temp = new Random().Next(minValue, maxValue + 1) / 10f;
        array[i] = Math.Round(temp, 3);
    }
    return array;
}

int num = Proverka();

double[] array = CreateArray(num, 1, 100);
Console.WriteLine($"[ {string.Join("  ", array)}] -> {SumDifference(array)}");




