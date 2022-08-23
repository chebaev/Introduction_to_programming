int Proverka()
{
    int number;
    while (true)
    {
        Console.Write("Введите число: ");
        string str = Console.ReadLine();

        try
        {
            number = Convert.ToInt32(str);
            return number;
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка! Неверное число. ");
        }
    }
}


//Console.WriteLine("Ввидите чсло");
int N = Proverka();//Convert.ToInt32(Console.ReadLine());

int count = 1;
string temp = "";
while(count <= N)
{
    temp = temp +' '+ Math.Pow(count, 3);
    
    count++;      
}
Console.WriteLine($"{N} ->  {temp} "); 