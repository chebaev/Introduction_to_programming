// string Proverka(string message)
// {
    
//     while (true)
//     {
//         Console.Write(message);
//         string str = Console.ReadLine();
//         Console.WriteLine(str);
//         try
//         {
//             Convert.ToInt32(str);
//             return str;
//         }
//         catch (Exception)
//         {
//             Console.WriteLine("Ошибка! Неверное число. ");
//         }
//     }
// }
// string text_1 = "Введите координаты первой точки через пробел: ";
// string text_2 = "Введите координаты второй точки через пробел: ";
// //Console.WriteLine("Введите координаты первой точки через пробел: ");
// string str = Proverka(text_1);
// int[] A = str.Split(' ').Select(int.Parse).ToArray();
// //Console.WriteLine("Введите координаты второй точки через пробел: ");
// string str1 = Proverka(text_2);
// int[] B = str1.Split(' ').Select(int.Parse).ToArray();


// Console.WriteLine(" ");
// Console.WriteLine("------------------------------------------");

// double summa = 0;
// string strA ="", strB="";
// for (int i = 0; i < A.Length; i++)
// {
//         strA = strA + ' '+ A[i];
//         strB = strB +' '+ B[i];  
//         summa = summa + Math.Pow(A[i] - B[i], 2);
//         //Console.WriteLine($"A[i] = {A[i]}  B[i] = {B[i]} summa = {summa}");
// }
// summa = Math.Sqrt(summa);
// Console.WriteLine($"A ({strA} ); B ({strB} ) -> {summa}");





string[] temp = {"3", "6", "8"}; 

for (int i = 0; i < temp.Length; i++)
{
    Console.WriteLine(temp[i]);
}
//Console.WriteLine(temp);


