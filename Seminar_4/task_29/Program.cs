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

string text = "Введите массив чисел через запетую (,): ";
string str = Proverka(text);
int[] array = str.Split(',').Select(int.Parse).ToArray();
string temp = "";

for (int i = 0; i < array.Length; i++)
{
    if (temp == "")
    {
        temp = Convert.ToString(array[i]);
    }
    else
    {
        temp = temp + ", " + Convert.ToString(array[i]);
    }
}

Console.WriteLine($"{temp} -> [{temp}]");


