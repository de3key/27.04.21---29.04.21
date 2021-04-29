using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.2

            int s = 0;
            int n = 0;
            Console.WriteLine("СНИГГЕРС ВВЕДИ ЧИСЛО");
            int a = Convert.ToInt32(Console.ReadLine());

            while (a > 0)
            {
                s = s + a;
                n = n + 1;
                Console.WriteLine("СНИГГЕРС ВВЕДИ ЧИСЛО");
                a = Convert.ToInt32(Console.ReadLine());

            }
            double Sr = 1.0 * s / n;
            Console.WriteLine(Sr);
            Console.ReadKey();
        }
    }
}
