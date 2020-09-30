using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*  Даны натуральные числа n, m. Получить их общие делители.
 */
namespace _0_8
{
    class Program
    {
        static void Main()
        {
            int s, s2;
            List<int> deliteli = new List<int>(5);
            List<int> deliteli2 = new List<int>(5);
            while (true)
            {
                Console.Clear();
                Console.Write("Введите первое натуральное число: ");
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

            while (true)
            {
                Console.Clear();
                Console.Write("Введите второе натуральное число: ");
                if (!int.TryParse(Console.ReadLine(), out s2) || ((s2 < 0) || (s2 % 1 != 0)))
                {
                    Console.WriteLine("Условия не соблюдены. Повторите ввод.");
                    Console.ReadKey();
                }
                else
                {
                    if ((s2 > 0) && (s2 % 1 == 0)) break;
                }
            }
            for (int i = 1; i <= Math.Sqrt(s2); i++)
            {
                if (s2 % i == 0)
                {
                    deliteli2.Add(i);

                    //для корня из s2 не существует парного делителя
                    if (i * i != s2)
                    {
                        deliteli2.Add(s2 / i);
                    }
                }
            }
            deliteli.Sort();
            deliteli2.Sort();
            Console.Clear();

            Console.WriteLine($"Количество делителей числа {s}: {deliteli.Count}");
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
            Console.WriteLine();
            Console.WriteLine($"Количество делителей числа {s2}: {deliteli2.Count}");
            Console.Write($"Делители числа {s2}: ");
            for (int i = 0; i < deliteli2.Count; ++i)
            {
                if (i < (deliteli2.Count - 1))
                {
                    Console.Write($" {deliteli2[i]},");
                }
                else
                {
                    Console.Write($" {deliteli2[i]}.");
                }
            }

            Console.WriteLine();
            Console.Write("Общие делители:");
            if (deliteli.Count <= deliteli2.Count)
            {
                for (int i = 0; i < deliteli2.Count; ++i)
                {
                    for (int j = 0; j < deliteli.Count; ++j)
                    {
                        if(deliteli[j] == deliteli2[i])
                        {
                            Console.Write($" {deliteli2[i]}");
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < deliteli.Count; ++i)
                {
                    for (int j = 0; j < deliteli2.Count; ++j)
                    {
                        if (deliteli[i] == deliteli2[j])
                        {
                            Console.Write($" {deliteli2[j]}");
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
