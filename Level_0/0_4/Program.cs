using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Определить, есть ли среди первых четырех цифр дробной 
 * части заданного положительного вещественного числа, цифра 5.
 */
namespace _0_4
{
    class Program
    {
        static void Main()
        {
            double s;
            int len;
            bool check = false;
            while (true)
            {
                Console.Clear();
                Console.Write("Введите вещественное число больше нуля: ");
                if (!Double.TryParse(Console.ReadLine(), out s) || ((s < 0) || (s % 1 == 0)))
                {
                    Console.WriteLine("Условия не соблюдены. Повторите ввод.");
                    Console.ReadKey();
                }
                else
                {
                    if ((s > 0) && (s % 1 != 0)) break;
                }
            }

            var paz = s.ToString().Split('.', ',')[1];
            Console.WriteLine($"Дробная часть: {paz}");
            len = paz.Length;
            for (int i = 0; i < len; ++i)
            {
                if (i > 3) break;
                else
                {
                    if (Convert.ToInt16(paz[i]) == '5')
                    {
                        check = true;
                        break;
                    }
                }
            }
            if (check)
            {
                Console.WriteLine("Среди первых четырёх цифр дробной части есть цифра 5!");
            }
            else
            {
                Console.WriteLine("Среди первых четырёх цифр дробной части нет цифры 5!");
            }
            Console.ReadKey();
        }
    }
}
