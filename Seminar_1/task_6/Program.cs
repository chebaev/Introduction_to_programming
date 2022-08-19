int number = 0;
bool flag = true;

while (flag)
{
    Console.Write($"Введите число: ");
    string str = Console.ReadLine();
 
   
        if (Proverka(str) == "Число")
        {
            number = int.Parse(str);
            if ((number % 2) == 0)
            {
                Console.WriteLine($"{number} -> да");
                
            }
            else
            {
               Console.WriteLine($"{number} -> нет"); 
            }
        flag = false;
        }
        else
        {
            Console.Clear();
        }
}


static string Proverka(string str)
{
    try
    {
        Convert.ToInt32(str);
        return "Число";
    }
    catch (Exception)
    {
        return "Не число";
    }

}

