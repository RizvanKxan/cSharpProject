using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*  Найдите сумму первых n натуральных чисел, которые делятся на 3 без остатка.
 */
namespace _0_6
{
    class Program
    {
        static void Main()
        {
            int s;
            int summ = 0;
            int count = 0;
            while (true)
            {
                Console.Clear();
                Console.Write("Введите сколько натуральных чисел, делящихся на 3 без остатка, необходимо сложить: ");
                if (!int.TryParse(Console.ReadLine(), out s) || ((s < 0) || (s % 1 != 0)))
                {
                    Console.WriteLine("Условия не соблюдены. Повторите ввод.");
                    Console.ReadKey();
                }
                else
                {
                    if ((s > 0) && (s % 1 == 0)) break;
                }
            }
            Console.Write("Натуральные числа, которые складывались: ");
            int i = 0;
            while (true)
            {
                if (i % 3 == 0)
                {
                    ++count;
                    if (count < s)
                    {
                        Console.Write($"{i}, ");
                        summ += i;
                    }
                    else if (count == s)
                    {
                        Console.Write($"{i}. ");
                        summ += i;
                    }

                    else
                    {
                        break;
                    }
                }
                ++i;
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма чисел равна: {summ}.");
            Console.ReadKey();
        }
    }
}
