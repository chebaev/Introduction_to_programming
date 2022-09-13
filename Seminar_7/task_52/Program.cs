// Функция заполнения массива
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
//Функция Найти среднее арифметическое
double[] FindArithmeticMean(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    double[] temp = new double[col];
    double sum = 0;
    int count = 0;

    for (int i = 0; i < col; i++)
    {
        for (int j = 0; j < row; j++)
        {
            sum = sum + array[j, i];
        }
        temp[i] = Math.Round(sum / row, 2);
        sum = 0;
    }
    return temp;
}

int[,] myarray = GetArray(3, 4, 1, 10);

PrintArray(myarray);
Console.WriteLine($" Среднее арифметическое каждого столбца: {string.Join("; ", FindArithmeticMean(myarray))} . ");