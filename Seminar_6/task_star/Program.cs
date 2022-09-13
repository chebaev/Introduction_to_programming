
// int[,] RotateClockwise(int[,] m)
// {
//     var result = new int[m.GetLength(1), m.GetLength(0)];

//     for (int i = 0; i < m.GetLength(1); i++)
//         for (int j = 0; j < m.GetLength(0); j++)
//             result[i, j] = m[m.GetLength(0) - j - 1, i];

//     return result;
// }

// int[,] RotateCounterClockwise(int[,] m)
// {
//     var result = new int[m.GetLength(1), m.GetLength(0)];

//     for (int i = 0; i < m.GetLength(1); i++)
//         for (int j = 0; j < m.GetLength(0); j++)
//             result[i, j] = m[j, m.GetLength(1) - i - 1];

//     return result;
// }

// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9
// int[,] array = {{1, 2, 3},{4,5, 6},{7, 8, 9}};

// Console.WriteLine($"Строки = {array.GetLength(0)}");
// Console.WriteLine($"Столбци = {array.GetLength(1)}");
// int row = array.GetLength(0);
// int col = array.GetLength(1);

// int[,] result = new int[col, row];

// for(int i = 0; i < col; i++)
//     for(int j = 0; j < row; j++)
//         result[i,j] = array[j, col - i -1];


// foreach (int elem in result)
// {
//     Console.WriteLine(elem);
// }

// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9

// void Program()
// {
//   int[,] num = new int[10, 10];
//   for (int i = 1; i < num.GetLength(0); i++)
//   {
//     for (int j = 1; j < num.GetLength(1); j++)
//     {
//       Console.Write($"{i}*{j}={i*j} \t");
//     }
//     Console.WriteLine("\n");
//   }
// }       

// Program();

// int[,] myarray = {{1, 2, 3},{4,5, 6},{7, 8, 9}};
// //int[] temp = new int[];
// string temp = " ";
// int row = myarray.GetLength(0);
// int col = myarray.GetLength(1);
// for(int i = 0; i < row; i++)
// {
//   temp = temp + " " + myarray[row - 1,i];

// }

// for(int j = col - 2; j < col; j--)
// {
//   if (j >= 0)
//   {
//    temp = temp + " " + myarray[j,col-1];

//   }
// }


// for(int n = col - 2; n == 0; n--)
// {
//   temp = temp + " " + myarray[0,n];
//   Console.WriteLine($" {string.Join(", ", temp)}");

// }
// Console.WriteLine($" {string.Join(", ", temp)}");
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

// int c = 6;
// int r = 7;
// int[,] mac = new int[r, c];
// mac = GetArray(n, n, 1, 10);
// PrintArray(mac);


int[,] myarray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
// Console.WriteLine(myarray.GetLength(0) + myarray.GetLength(1));
// Console.WriteLine(myarray.Length);
int count = 0;
int startRow = myarray.GetLength(0)-1;
int endRow = myarray.GetLength(0) - 1;
int startCol = 0;
int endCol = myarray.GetLength(1) - 1;
int[] result = new int[myarray.Length];

while (startCol <= endCol && startRow <= endRow)
{
  //+++++++++++++++++++++++
    for (int i = startCol; i <= endCol; i++)
    {
        result[count] = myarray[startRow, i];
        count++;
    }
    Console.WriteLine($"[{string.Join(", ", result)}]"); 
    Console.ReadLine();
    startRow--;
  //+++++++++++++++++++++++
    for (int j = startRow; j <= endRow; j--)
    {
        Console.WriteLine($"{myarray[j, endCol]}"); 
        Console.WriteLine($"[{string.Join(", ", result)}]"); 
        Console.WriteLine($"count = {count}");
        Console.ReadLine();
        result[count] = myarray[j, endCol];
        count++;
    }
    Console.WriteLine($"[{string.Join(", ", result)}]"); 
    Console.ReadLine();
    endCol++;

    for (int i = endCol; i >= startCol; i--)
    {
        Console.WriteLine($"{myarray[i, endCol]}"); 
        result[count] = myarray[endRow, i];
        count++;
    }
    Console.WriteLine($"[{string.Join(", ", result)}]"); 
    Console.ReadLine();
    endRow++;

    for (int j = endRow; j >= startRow; j++)
    {
        result[count] = myarray[j, startCol];
        count++;

    }
    Console.WriteLine($"[{string.Join(", ", result)}]"); 
    Console.ReadLine();
    startCol++;

}

PrintArray(myarray);
Console.WriteLine($"[{string.Join(", ", result)}]"); 



// while (startCol <= endCol && startRow <= endRow)
// {
//     for (int i = startCol; i <= endCol; i++)
//     {
//         result[count] = myarray[startRow, i];
//         count++;
//     }
//     startRow++;
       //+++++++++++++++++++++++
//     for (int j = startRow; j <= endRow; j++)
//     {
//         result[count] = myarray[j, endCol];
//         count++;
//     }
//     endCol--;

//     for (int i = endCol; i >= startCol; i--)
//     {
//         result[count] = myarray[endRow, i];
//         count++;
//     }
//     endRow--;
//     for (int j = endRow; j >= startRow; j--)
//     {
//         result[count] = myarray[j, startCol];
//         count++;

//     }
//     startCol++;

// }