using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Начальный вклад в банке равен 1000 руб. Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы.
//По данному P определить, через сколько месяцев размер вклада превысит 2100 руб., и вывести найденное количество месяцев K и итоговый размер вклада S.
namespace _0_1
{
    class Program
    {
        static void Main()
        {
            int firstDeposit = 1000; // начальный вклад
            int stopDeposit = 2100; // граница выхода
            int collMonth = 0; // количество месяцев
            double resultDeposit = firstDeposit; // итоговый размер вклада
            double tempDeposit; // депозит для счёта
            int p; // процент 

            Console.Write("Введите размер процента по вкладу: ");
            p = Convert.ToInt32(Console.ReadLine());

            while (resultDeposit < stopDeposit)
            {
                tempDeposit = (resultDeposit * p) / 100;
                resultDeposit += tempDeposit;
                ++collMonth;
            }

            Console.WriteLine($"Начальный депозит: {firstDeposit}, размер процента: {p}, граница выхода: {stopDeposit}.");
            Console.WriteLine($"Итоговый вклад: {resultDeposit}, достигнут через {collMonth} месяца/ев.");
            Console.ReadKey();
        }
    }
}
