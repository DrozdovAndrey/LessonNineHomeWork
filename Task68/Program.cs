// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

namespace HomeWork9
{
    class Task68
    {
        static void Main(string[] args)
        {
            int n = new Random().Next(1, 4);
            int m = new Random().Next(1, 4);
            Console.WriteLine($"n = {n},  m = {m}");
            Console.WriteLine(Akerman(n,m));
        }
        static int Akerman(int n, int m)
        {
            if (n == 0)
                return m + 1;
            else
              if ((n != 0) && (m == 0))
                return Akerman(n - 1, 1);
            else
                return Akerman(n - 1, Akerman(n, m - 1));
        }
    }
}