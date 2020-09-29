using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*  Дано натуральное число n. Получить все его натуральные делители.
 */
namespace _0_7
{
    class Program
    {
        static void Main()
        {
            int s;
            List<int> deliteli = new List<int>(5);
            while (true)
            {
                Console.Clear();
                Console.Write("Введите натуральное число для которого надо найти делители: ");
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
            for (int i = 1; i <= Math.Sqrt(s); i++)
            {
                if (s % i == 0)
                {
                    deliteli.Add(i);
                    //для корня из s не существует парного делителя
                    if (i * i != s)
                    {
                        deliteli.Add(s / i);
                    }
                }
            }

            deliteli.Sort();
            Console.WriteLine($"Количество делителей: {deliteli.Count}");
            Console.Write($"Делители числа {s}: ");
            for (int i = 0; i < deliteli.Count; ++i)
            {
                if (i < (deliteli.Count - 1))
                {
                    Console.Write($" {deliteli[i]},");
                }
                else
                {
                    Console.Write($" {deliteli[i]}.");
                }
            }
            Console.ReadKey();
        }
    }
}
