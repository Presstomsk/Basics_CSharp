/*Дано целое число N (> 0), найти число, полученное при прочтении 
числа N справа налево. Например, если было введено число 345,  то  программа 
должна вывести число 543. */


using System;

namespace Work5
{
    class Program
    {
        static void Main()
        {
            int N,reverseN;
            Console.Write("Введите значение числа N большее 0: ");
            N = Convert.ToInt32(Console.ReadLine());
            if (N < 0) N = -N;
            while (N == 0)
            {
                Console.Write("N=0. Введите корректное значение числа N: ");
                N = Convert.ToInt32(Console.ReadLine());
            }            
            string number = Convert.ToString(N);           
            char[] elements = number.ToCharArray();
            Array.Reverse(elements);
            number = new string(elements);
            reverseN = Convert.ToInt32(number);
            Console.WriteLine($"Реверсивное значение числа {N} равно {reverseN}");        
            

        }
    }
}
