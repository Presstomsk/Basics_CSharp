//ДЗ 3.Даны целые положительные числа A и B(A<B).
//Вывести все целые числа от A до B включительно;
//каждое число должно выводиться на новой строке;
//при этом каждое число должно выводиться количество раз,
//равное его значению. Например: если А = 3, а В = 7,
//то программа должна сформировать в консоли следующий вывод:
//3 3 3
//4 4 4 4
//5 5 5 5 5
//6 6 6 6 6 6
//7 7 7 7 7 7 7



using System;

namespace Work4
{
    class Program
    {
        static void Main()
        {
            int A, B, C;
            Console.Write("Введите значение числа A: ");
            A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение числа B: ");
            B = Convert.ToInt32(Console.ReadLine());
            if (A > B)
            {
                C = A;
                A = B;
                B = C;
            }
            for (; A <= B; A++)
            {
                for (int i = 0; i < A; i++)
                {
                    Console.Write($"{A}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
