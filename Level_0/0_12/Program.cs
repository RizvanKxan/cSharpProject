using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Вывести последовательность чисел b1...bn, получающуюся при чтении заданной квадратной матрицы порядка n по схеме из рисунка (файл в папке проекта). 
namespace _0_12
{
    class Program
    {
        

        static void Main()
        {
            int n;
            Console.Write("Enter dimension: ");
            while(true)
            {
                if((!int.TryParse(Console.ReadLine(), out n)) || (n <=0))
                {
                    Console.WriteLine("Incorrect input. Try it again.");
                }
                else
                {
                    break;
                }
            }

            Random rnd = new Random();
            int [,] mass = new int[n,n];

            Console.Clear();
            Console.WriteLine("Array: ");
            Console.WriteLine();
            for(int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    mass[i, j] = rnd.Next(1, 100);
                    Console.Write("{0,4}", mass[i, j]);
                }
                Console.WriteLine();
            }
            int b = 0; int a = 0;
            List<int> elem = new List<int>(n * n);
            for(int j = 0; j < n; ++j)
            {
                if (a == n && b == 0)
                {
                    a = 0;
                }

                for (int i = 0; i < n; ++i)
                {
                    if (a < n)
                    {
                        elem.Add(mass[a, j]);
                        a++;
                        b = a;
                        continue;
                    }
                    
                    if (b > 0)
                    {
                        --b;
                        elem.Add(mass[b, j]);
                        continue;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Result sequence: ");
            Console.WriteLine();

            foreach (int i in elem)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

    }
}
