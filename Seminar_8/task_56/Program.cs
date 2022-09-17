//Функция для формирования массива 
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
//Функция нахождения суммы в строчки массива
int[] FindingSumRowsArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int sum = 0;
    int[] temparray = new int[row];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            sum += array[i, j];
        }
        temparray[i] = sum;
        sum = 0;
    }
    return temparray;
}
//Функция нахождения минимума в массиве
void FindingMinimumArray(int[] array)
{
    int mintemp = array[0];
    int count = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (mintemp > array[i])
        {
            mintemp = array[i];
            count = i;
        }
    }
    Console.WriteLine($" Строка с наименьшей суммой элементов: {count + 1} строка");
}

int[,] myarray = GetArray(4, 4, 1, 30);

PrintArray(myarray);
Console.WriteLine();
FindingMinimumArray(FindingSumRowsArray(myarray));
