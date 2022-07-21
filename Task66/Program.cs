// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

namespace HomeWork9
{
    class Task66
    {
        static void Main(string[] args)
        {
            int n = new Random().Next(3,10);
            int m = new Random().Next(3,10);
            Console.WriteLine($"n = {n},  m = {m}");
            int sum = 0;
            if (m == n) Console.WriteLine(n);
            if (n < m) 
            {  
                for (int i = n; i <= m; i++)
                {
                    sum += i;
                    
                }
                Console.Write(sum);            
            }
            if (n > m)
            {
                for (int j = n; j >= m; j--)
                {
                    sum += j;
                }
                Console.Write(sum);
            }
        }
    }
}