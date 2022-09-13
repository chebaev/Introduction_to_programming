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

double[] Average(int[,] array)
{
    
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    double[] temp = new double[col];
    double sum = 0;
    int count = 0;

    for (int i  = 0; i < col; i++)
    {
        //Console.WriteLine($"i = {i}");
       for (int j = 0; j < row; j++)
       {
        //Console.WriteLine($"j = {j}");
        sum = sum + array[j,i];
        //Console.WriteLine($"sum = {array[j, i]}");
       }
       //Console.WriteLine($"col = {col}");
       temp[i] = Math.Round(sum / row,2);
       //count++;
       
        sum = 0;
    }
    return temp;
} 

int[,] myarray =  {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

PrintArray(myarray);
Console.WriteLine($" Среднее арифметическое каждого столбца: {string.Join("; ", Average(myarray))}.");