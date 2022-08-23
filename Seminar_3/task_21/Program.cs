// See https://aka.ms/new-console-template for more information
//Console.WriteLine(Math.Sqrt(((3-2)*2 + (6-1)*2 + (8-(-7))*2)*2));
// double R = Math.Sqrt(Math.Pow(3 - 2, 2) + Math.Pow(6 - 1, 2)+ Math.Pow(8 - (-7), 2));
// Console.WriteLine("R = {0}", R);

// R = Math.Sqrt(Math.Pow(7 - 1, 2) + Math.Pow(-5 - (-1), 2)+ Math.Pow(0 - 9, 2));
// Console.WriteLine("R = {0}", R);
// double R = Math.Sqrt(Math.Pow(3 - 6, 2) + Math.Pow(2 - 1, 2));
// Console.WriteLine("R = {0}", R);


Console.WriteLine("Введите координаты первой точки через пробел: ");
string str = Console.ReadLine();
int[] A = str.Split(' ').Select(int.Parse).ToArray();
Console.WriteLine("Введите координаты второй точки через пробел: ");
string str1 = Console.ReadLine();
Console.WriteLine(" ");
Console.WriteLine("------------------------------------------");
int[] B = str1.Split(' ').Select(int.Parse).ToArray();
double summa = 0;
string strA ="", strB="";
for (int i = 0; i < A.Length; i++)
{
        strA = strA + ' '+ A[i];
        strB = strB +' '+ B[i];  
        summa = summa + Math.Pow(A[i] - B[i], 2);
        //Console.WriteLine($"A[i] = {A[i]}  B[i] = {B[i]} summa = {summa}");
}
summa = Math.Sqrt(summa);
Console.WriteLine($"A ({strA} ); B ({strB} ) -> {summa}");
