//Функция для формирования массива 
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int row = 0; row < m; row++)
    {
        for (int col = 0; col < n; col++)
        {
            result[row, col] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

//Функция для вывода массива в консоль 
void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($" {array[row, col]}\t");
        }
        Console.WriteLine();
    }
}

//Функция нахождения производной двух матриц 
int[,] ProductOfTwoMatrices(int[,] array1, int[,] array2)
{
    int row1 = array1.GetLength(0);
    int col1 = array1.GetLength(1);
    int row2 = array2.GetLength(0);
    int col2 = array2.GetLength(1);
    int[,] temparray = new int[row1, col2];

    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < col1; j++)
        {
            int summ = 0;
            for (int k = 0; k < row2; k++)
            {
                summ += array1[i, k] * array2[k, j];
            }
            temparray[i, j] = summ;
        }
    }
    return temparray;
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


void main()
{
    bool flag = true;
    while (flag)
    {
        int row1 = GetData("Введите число строк 1-й матрицы: ");
        int column1 = GetData("Введите число столбцов 1-й матрицы : ");
        int range1 = GetData("Введите диапазон случайных чисел: от 1 до ");
        int row2 = GetData("Введите число строк 2-й матрицы: ");
        int column2 = GetData("Введите число столбцов 2-й матрицы: ");
        int range2 = GetData("Введите диапазон случайных чисел: от 1 до ");

        if (column1 == row2)
        {
            int[,] array1 = GetArray(row1, column1, 1, range1);
            int[,] array2 = GetArray(row2, column2, 1, range2);
            Console.WriteLine("Первая матрица:");
            PrintArray(array1);
            Console.WriteLine();
            Console.WriteLine("Вторая матрица:");
            PrintArray(array2);
            Console.WriteLine();
             Console.WriteLine("Вывод :");
            PrintArray(ProductOfTwoMatrices(array1, array2));
            flag = false;
        }
        else
        {
            Console.WriteLine("Нельзя найти произведение двух матриц!");
            Console.WriteLine("Неверно введены данные. Попробуйте ещё раз. Число строк первой матрицы должно совпадать с  числом столбцов второй матрицы.");
            Console.WriteLine("Нажмите Enter для продолжения программы.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}


main();