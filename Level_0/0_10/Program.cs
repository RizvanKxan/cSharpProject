using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*  Преобразовать массив так, чтобы сначала шли отрицательные числа, а затем положительные (0 считать положительным).
 */
namespace _0_10
{
    class Program
    {
        static void Main()
        {
            int len;
            Console.Write("Задайте длину массива: ");
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
            int[] array = new int[len];
            for (int i = 0; i < len; ++i)
            {
                Console.Write($"Введите значение {i} элемента: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(array);

            Console.WriteLine("Получившийся массив: ");
            for (int i = 0; i < len; ++i)
            {
                if (i == len - 1)
                {
                    Console.Write($"{array[i]}.");
                }
                else
                {
                    Console.Write($"{array[i]}, ");
                }
            }
            Console.ReadKey();
        }
    }
}
