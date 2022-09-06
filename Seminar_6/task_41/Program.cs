
// Функция проверки массива на число
// string Proverka(string message)
// {

//     while (true)
//     {
//         Console.Write(message);
//         string str = Console.ReadLine();
//         string[] temp = str.Split(',');

//         for (int i = 0; i < temp.Length; i++)
//         {
//             try
//             {
//                 Convert.ToInt32(temp[i]);

//             }
//             catch (Exception)
//             {
//                 Console.WriteLine("Ошибка! Неверное число. ");
//             }
//         }
//         return str;
//     }
// }

// int AmountOfNumbers()
// {
//     pass;
// }

// string text = "Введите массив чисел через запетую (,): ";
// string str = Proverka(text);
// int[] array = str.Split(',').Select(int.Parse).ToArray();

//Console.WriteLine("Сколько чисел будете проверять. Введите число: ");
// int number = Console.ReadLine();
// bool isNum = double.TryParse()


bool CheckingForNumber(string str)
{
    int num;
    bool isNum = int.TryParse(str, out num);
    return isNum;
}
int GetData(string message)
{
    while(true)
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
        }
    }
}

void HowManyNumbers(int num)
{
    int count = 0;
    int[] temp = new int[num];
    for (int i = 1; i<=num; i++)
    {
        int number = GetData($"Введите {i} число: ");
        temp[i-1] = number;
        if (number > 0)
        {
            count++;
        }
    }
    Console.WriteLine($" {string.Join(", ", temp)} -> {count}");
      
}

string messag = "Сколько чисел будете проверять. Введите число: ";
HowManyNumbers(GetData(messag));

