using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            int min = 0;
            int p = 0;

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(-10, 10);
                if (mas[i] < min)
                {
                    min = mas[i];
                    p = i;
                }
            }

            foreach (int el in mas)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            int s = 0;
            int l = 0;
            for (int i = 0; i < n; i++)
            {
                if (((mas[i - l] % 2) == 0) && ((((i) + 1) % 2) == 0) && ((i) >= (p + 1)) && (mas[i - l] > 0))
                {
                    Console.WriteLine("{0},{1}", i, mas[i - l]);
                    l += 1;

                    for (int j = i - s; j < n - l; j++)
                    {
                        mas[j] = mas[n - (n - j) + 1];
                    }
                    s += 1;
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n - l; i++)
            {
                Console.Write(mas[i] + " ");
            }

            Console.ReadKey();
        }

    }
}
