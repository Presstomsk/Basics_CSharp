/*Задание 3. Числовые  значения  символов  нижнего  регистра  в  коде  ASCII 
отличаются от значений символов верхнего регистра на величину 32. Используя эту  
информацию, написать программу, которая считывает с клавиатуры и конвертирует 
все символы нижнего регистра в символы верхнего регистра и наоборот.*/


using System;

namespace Work3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите строку с клавиатуры: ");
            int size = 50;
            char[] arr = new char[size];
            int counter = 0;
            do
            {
                arr[counter] = Console.ReadKey().KeyChar;
                counter++;

            }
            while ((counter != arr.Length) && (arr[counter - 1] != 13));
            Console.WriteLine();
            for (int i = 0; i < counter - 1; i++)
            {

                if ((arr[i] >= 97) && (arr[i] <= 122))
                    arr[i] = (char)((int)arr[i] - 32);
                else if ((arr[i] >= 65) && (arr[i] <= 90))
                    arr[i] = (char)((int)arr[i] + 32);
            }
            Console.Write("Результат конвертирования: ");
            for (int i = 0; i < counter - 1; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
