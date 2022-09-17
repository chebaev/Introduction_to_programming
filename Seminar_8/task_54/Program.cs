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

//Функция упорядочить массив по убыванию
int[,] SortArrayDescending(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < col - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i,k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
        
    }
    return array;
}


int[,] myarray = GetArray(4, 4, 1, 8 );
PrintArray(myarray);
Console.WriteLine();
myarray = SortArrayDescending(myarray);
PrintArray(myarray);