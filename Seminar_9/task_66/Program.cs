//Функция нахождения суммы натуральных элементов в промежутке от M до N
int PrintSummNumbers(int startNumber, int endNumber)
{
    return startNumber == endNumber ? startNumber : startNumber + PrintSummNumbers(startNumber + 1, endNumber);
}

//Функция проверки на число
bool CheckingForNumber(string str)
{
    int num;
    return int.TryParse(str, out num);
}

//Фукция вывода сообщений и получения числа
int GetData(string message)
{
    while (true)
    {
        Console.Write(message);
        string number = Console.ReadLine();
        if (CheckingForNumber(number))
        {
            return int.Parse(number);
            break;
        }
        else
        {
            Console.WriteLine("Введено не число. Попробуйте ещё раз.");
            Console.WriteLine();
        }
    }
}

//Функция основная 
void main()
{
    bool flag = true;
    while (flag)
    {
        int m = GetData("Введите М: ");
        int n = GetData("Введите N: ");
        if (m < n)
        {
            Console.WriteLine($"M = {m}; N = {n} -> {PrintSummNumbers(m, n)}");
            flag = false;
        }
        else
        {
            Console.WriteLine("Введены не верные значения. Повторите попытку снова.");
            Console.WriteLine("Нажмите Enter для продолжения.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}


main();