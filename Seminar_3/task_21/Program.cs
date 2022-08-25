string Proverka(string message)
{

    while (true)
    {
        Console.Write(message);
        string str = Console.ReadLine();
        string[] temp = str.Split(' ');

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
string text_1 = "Введите координаты первой точки через пробел: ";


string str = Proverka(text_1);
int[] A = str.Split(' ').Select(int.Parse).ToArray();
string text_2 = "Введите координаты второй точки через пробел: ";
string str1 = Proverka(text_2);
int[] B = str1.Split(' ').Select(int.Parse).ToArray();


Console.WriteLine(" ");
Console.WriteLine("------------------------------------------");

double summa = 0;
string strA = "", strB = "";
for (int i = 0; i < A.Length; i++)
{
    strA = strA + ' ' + A[i];
    strB = strB + ' ' + B[i];
    summa = summa + Math.Pow(A[i] - B[i], 2);
}
summa = Math.Sqrt(summa);
Console.WriteLine($"A ({strA} ); B ({strB} ) -> {summa.ToString("F" + 2)}");






