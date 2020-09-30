using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*  Сжать массив, удалив из него все 0. Заполнить освободившиеся справа элементы значениями -1.
 */
namespace _0_9
{
    class Program
    {
        static void Main()
        {
            int len;
            Console.Write("Задайте длину массива: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out len) || (len < 0))
                {
                    Console.WriteLine("Условия не соблюдены. Повторите ввод.");
                }
                else
                {
                    break;
                }
            }

            int[] array = new int[len];
            int[] array_result = new int[len];
            Console.WriteLine("Хотя бы один элемент должен быть равен нулю.");
            for (int i = 0; i < len; ++i)
            {
                Console.Write($"Задайте значение для {i} элемента: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = 0;
            Console.WriteLine("Начальный массив: ");
            for (int i = 0; i < len; ++i)
            {
                if (array[i] != 0)
                {
                    array_result[j] = array[i];
                    ++j;
                }
                if (i == len - 1)
                {
                    Console.Write($"{array[i]}.");
                    break;
                }
                else
                {
                    Console.Write($"{array[i]}, ");
                }

            }

            for (int i = j; i < len; ++i)
            {
                array_result[i] = -1;
            }

            Console.WriteLine();
            Console.WriteLine("Итоговый массив: ");
            for (int i = 0; i < len; ++i)
            {
                if (i == len - 1)
                {
                    Console.Write($"{array_result[i]}.");
                    break;
                }
                else
                {
                    Console.Write($"{array_result[i]}, ");
                }
            }
            Console.ReadKey();
        }
    }
}
