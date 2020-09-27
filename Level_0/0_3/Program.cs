using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Дано целое число N > 0, найти число, полученное при прочтении  
 * числа N справа налево. Например, если было введено число 345, то
 * программа должна вывести число 543.
 */
namespace _0_3
{
    class Program
    {
        static void Main()
        {
            int a, b;
            string aStr, bStr;

            Console.Write("Введите целое число больше нуля: ");
            aStr = Console.ReadLine();

            a = Convert.ToInt32(aStr);
            bStr = new string(aStr.Reverse().ToArray());
            b = Convert.ToInt32(bStr);

            Console.WriteLine($"Введённое число: {a}, результат: {b}.");
            Console.ReadKey();
        }
    }
}
