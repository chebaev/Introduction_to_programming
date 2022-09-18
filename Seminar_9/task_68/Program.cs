
//Функции Аккермана
int Akkerman(int m, int n)
{
    return m == 0 ? n + 1 : n == 0 ? Akkerman(m - 1, 1) : Akkerman(m - 1, Akkerman(m, n - 1));
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
        int firstNumber = GetData("Введите М: ");
        int secondNumber = GetData("Введите N: ");
        if (firstNumber > 3 || secondNumber > 5)
        {
            Console.WriteLine("Введены не верные значения. Повторите попытку снова.");
            Console.WriteLine("Нажмите Enter для продолжения.");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"M = {firstNumber}; N = {secondNumber} -> A(m, n) = {Akkerman(firstNumber, secondNumber)}");
            flag = false;
        }
    }
}

main();