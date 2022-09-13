//Функция Значение римских цифр
int MeaningRomanNumbers(char value)
{
    switch (value)
    {
        case 'I': return 1;
        case 'V': return 5;
        case 'X': return 10;
        case 'L': return 50;
        case 'C': return 100;
        case 'D': return 500;
        case 'M': return 1000;
        default: return 0;
    }
}

//Функция перевода римских цифр
int TranslationRomanNumbers(string value)
{
    int sum = 0;
    int previousValue = 0;

    foreach (char letter in value)
    {
        int temp = MeaningRomanNumbers(letter);
        if (temp > 0)
        {
            if (temp > previousValue)
            {
                sum -= previousValue;
                sum += temp - previousValue;
                previousValue = temp;
            }
            else
            {
                sum += temp;
                previousValue = temp;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Внемание!! Введины не коректные данные. Попробуйте ещё раз.");
            main();
        }

    }
    return sum;
}

// Функция запуска основной программы
void main()
{
    Console.Write("Введите римские числа: ");
    string romanNumerals = (Console.ReadLine().ToUpper());
    Console.WriteLine($"{romanNumerals} -> {TranslationRomanNumbers(romanNumerals)}");
}


main();

