// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""




namespace HomeWork9
{
    class Task64
    {
        static void Main(string[] args)
        {
            int n = new Random().Next(3,10);
            int m = new Random().Next(3,10);
            Console.WriteLine($"n = {n},  m = {m}");
            if (m == n) Console.WriteLine(n);
            if (n < m) 
            {
                while(n < m)
                {
                    Console.Write($"{n},");
                    n++;
                }
                Console.Write(m);
            }
            if (n > m)
            {
                while(n > m)
                {
                    Console.Write($"{n},");
                    n--;
                }
                Console.Write(m);
            }
        }
    }
}