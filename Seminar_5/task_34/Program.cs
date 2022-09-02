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

///Функция Подсчет количества чётных чисел из массива
int GetCount(int[] temp)
{
    int count = 0;
    for (int i = 0; i < temp.Length; i++)
    {
        if (temp[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

///Функция Заполненный массива случайными трёхзначными числами
int[] CreateArray(int number, int minValue, int maxValue)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
int num = Proverka();

int[] array = CreateArray(num, 100, 1000);

Console.WriteLine($"[ {string.Join(", ", array)} ]  -> {GetCount(array)}");


