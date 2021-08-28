/*Ввести с клавиатуры номер трамвайного билета (6-значное число) и про-
верить  является  ли  данный  билет  счастливым (если  на  билете  напечатано 
шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то 
этот билет считается счастливым). */

using System;

namespace Work2
{
    class Work2
    {
        static void Main()
        {
            Console.Write("Введите номер билета:");

            char[] num = new char[6];
            int leftSum = 0, rightSum = 0;
            for (int counter = 0; counter < 6; counter++)
            {
                num[counter] = Console.ReadKey().KeyChar;
            }
            for (int counter = 0; counter < 3; counter++)
            {
                string snum = num[counter].ToString();
                leftSum = leftSum + Convert.ToInt32(snum);
                snum = num[counter + 3].ToString();
                rightSum = rightSum + Convert.ToInt32(snum);

            }

            Console.WriteLine();
            if (leftSum == rightSum) Console.WriteLine("Билет счастливый!!!");
            else Console.WriteLine("Билет не счастливый!!!");
        }
    }
}
