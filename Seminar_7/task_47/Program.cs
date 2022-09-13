//Функция формирования массива вещественными числами  
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];

    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            int temp = new Random().Next(minValue, maxValue +1);
            result[row, col] = new Random().NextDouble() * Convert.ToDouble(temp);
        }
    }
    return result;    
}
//Функция вывода массива в консоль
void PrintArray(double[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($" {array[row, col]:f1} \t");
        }
        Console.WriteLine();
    }
}

//Функция проверки на число возвращает true или false
bool Proverka(string stringTemp)
{
    int number = 0;
    if (int.TryParse(stringTemp, out number))
    { 
        return true;
    }
    return false;
}

//Функция запуска основной программы 
void main()
{
    int m = 0;
    int n = 0;
    while(true)
    {
        if(m == 0 && n == 0)
        {
            Console.Write("Введите число сколько строк будет в массиве: ");
            string temp = Console.ReadLine();
            if (Proverka(temp))
            {
                m = int.Parse(temp);
            }
            else 
            {
                Console.WriteLine("Внимание!!! Введено не число. Возможно Вы ошиблись. Попробуйте ещё раз. ");
            }
        }
        else if (m > 0 && n == 0)
        {
            Console.Write("Введите число сколько столбцов будет в массиве: ");
            string temp = Console.ReadLine();
            if (Proverka(temp))
            {
                n = int.Parse(temp);
            }
            else 
            {
                Console.WriteLine("Внимание!!! Введено не число. Возможно Вы ошиблись. Попробуйте ещё раз. ");
            }
        }
        else if (m > 0 && n > 0) 
        {
            double[, ] myArray = GetArray(m, n, -10, 10);
            Console.WriteLine($"       m = {m}  n = {n}");
            PrintArray(myArray);
            break;
        }
    }
}

main();