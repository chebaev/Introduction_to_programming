
//Функция формирования массива вещественными числами  
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            result[row, col] = new Random().Next(minValue, maxValue +1);
        }
    }
    return result;    
}

//Функция вывода массива в консоль
void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($" {array[row, col]} \t");
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

// Функция поиска числа в массиве
void SearchNumberArray(int[,] array, int num)
{
    string text = string.Empty;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            if (array[row, col] == num)
            {
                  text = $"{num} -> такое число есть по индексу [{row}, {col}]";
                  break;
            }
            else  text = $"{num} -> такого числа в массиве нет";
        }
    }
    Console.WriteLine();
    Console.WriteLine(text);
    
}

//Функция запуска основной программы 
void main()
{
    int number = 0;
    while(true)
    {
        if(number == 0)
        {
            Console.Write("Введите число для поиска в массиве: ");
            string temp = Console.ReadLine();
            if (Proverka(temp))
            {
                number = int.Parse(temp);
            }
            else 
            {
                Console.WriteLine("Внимание!!! Введено не число. Возможно Вы ошиблись. Попробуйте ещё раз. ");
            }
        }
        else if (number > 0) 
        {
            int[, ] myArray = GetArray(3, 4, 1, 10);
            PrintArray(myArray);
            SearchNumberArray(myArray, number);
            break;
        }
    }
}

main();