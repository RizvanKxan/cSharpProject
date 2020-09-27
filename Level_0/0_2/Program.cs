using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Даны целые положительные числа А и Б (А < Б). Вывести все целые числа от А до Б включительно;
 * каждое число должно выводиться с новой строки; при этом каждое число должно выводиться количество
 * раз, равное его значению. Например: А = 3, Б = 5:
 * 333
 * 4444
 * 55555
 */
namespace _0_2
{
    class Program
    {
        static void Main()
        {
            int a, b;
            while (true)
            {
                Console.Clear();
                Console.Write("Введите число A (A > 0): ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите число B (B > A и B < 30): ");
                b = Convert.ToInt32(Console.ReadLine());
                if ((a > 0) && (b > a) && (b < 30)) break;
                else
                {
                    Console.WriteLine("Условия не соблюдены, повторите ввод!");
                    Console.ReadKey();
                }
            }

            for (int i = a; i <= b; ++i)
            {
                PrintLineNumber(i);
            }
            Console.ReadKey();
        }
        static void PrintLineNumber(int x)
        {
            for (int i = 1; i <= x; ++i)
            {
                Console.Write(x);
            }
            Console.WriteLine();
        }
    }
}
