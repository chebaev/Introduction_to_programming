// Функция проверки массива на число
string Proverka(string message)
{

    while (true)
    {
        Console.Write(message);
        string str = Console.ReadLine();
        string[] temp = str.Split(',');

        for (int i = 0; i < temp.Length; i++)
        {
            try
            {
                Convert.ToInt32(temp[i]);

            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка! Неверное число. ");
            }
        }
        return str;
    }
}
// Функция Mетодом пузырька
int[] MethodBubble(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}

string text = "Введите массив чисел через запетую (,): ";
string str = Proverka(text);
int[] array = str.Split(',').Select(int.Parse).ToArray();

Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", MethodBubble(array))}]");