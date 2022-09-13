//Функция заполнения трёхмерного массива
int[,,] GetArray(int m, int n, int v, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, v];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {

            for(int k = 0; k < v; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue +1);
            }
        }
    }
    return result;    
}
//Функция вывода массива в консоль
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($" {array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }

}

int[,,] myarray = GetArray(2, 2, 2, 10, 99);
PrintArray(myarray);