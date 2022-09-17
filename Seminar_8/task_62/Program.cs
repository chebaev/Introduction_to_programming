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

int[,] FillingMatrixSpiral(int row, int col)
{
    int count = 1;
    int startRow = 0;
    int endRow = col - 1;
    int startCol = 0;
    int endCol = row - 1;

    int[,] result = new int[row, col];


    while (startCol <= endCol && startRow <= endRow)
    {
        for (int i = startCol; i <= endCol; i++)
        {
            result[startRow, i] = count;
            count++;
        }
        startRow++;

        for (int j = startRow; j <= endRow; j++)
        {
            result[j, endCol] = count;
            count++;
        }
        endCol--;

        for (int i = endCol; i >= startCol; i--)
        {
            result[endRow, i] = count;
            count++;
        }
        endRow--;
        for (int j = endRow; j >= startRow; j--)
        {
            result[j, startCol] = count;
            count++;

        }
        startCol++;

    }
    return result;
}


PrintArray(FillingMatrixSpiral(4, 4));