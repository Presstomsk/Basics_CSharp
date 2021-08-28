/*Задание 1. Написать программу, которая считывает символы с клавиатуры, пока не 
будет  введена  точка.  Программа  должна  сосчитать  количество  введенных 
пользователем пробелов.  */


using System;

namespace Work1
{
    class Work1
    {
        static void Main()
        {
            Console.Write("Введите символы с клавиатуры: ");
            char symbol;
            int counter = 0;
            do
            {
                symbol = Console.ReadKey().KeyChar;
                if (symbol == ' ')
                    counter++;
            }
            while (symbol != '.');
            Console.WriteLine();
            Console.WriteLine($"Число пробелов: {counter}");

        }
    }
}
