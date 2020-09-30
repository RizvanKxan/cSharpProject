using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*  В двумерном массиве порядка M на N поменяйте местами заданные столбцы. 
 */
namespace _0_11
{
    class Program
    {
        static void Main()
        {
            int len;
            Console.Write("Задайте размерность массива: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out len) || (len <= 0))
                {
                    Console.WriteLine("Условия не соблюдены, повторите ввод.");
                }
                else
                {
                    break;
                }
            }

            int[,] array = new int[len, len];
            Random rand = new Random();
            for (int i = 0; i < len; ++i)
            {
                for (int j = 0; j < len; ++j)
                {
                    array[i, j] = rand.Next(0, 10);
                }

            }

            Console.WriteLine("Сгенерированный массив: ");
            for (int i = 0; i < len; ++i)
            {
                for (int j = 0; j < len; ++j)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }

            int m, n;
            Console.Write("Укажите первый столбец для замены: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out m) || (m < 0))
                {
                    Console.WriteLine("Условия не соблюдены, повторите ввод.");
                }
                else
                {
                    break;
                }
            }

            Console.Write("Укажите второй столбец для замены: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out n) || (n < 0))
                {
                    Console.WriteLine("Условия не соблюдены, повторите ввод.");
                }
                else
                {
                    break;
                }
            }
            int temp;
            for (int i = 0; i < len; ++i)
            {
                for (int j = 0; j < len; ++j)
                {
                    if (j == m)
                    {
                        temp = array[i, j];
                        array[i, j] = array[i, n];
                        array[i, n] = temp;
                    }
                }

            }

            Console.WriteLine("Получившийся массив: ");
            for (int i = 0; i < len; ++i)
            {
                for (int j = 0; j < len; ++j)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
