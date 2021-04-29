using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.22

            int max = 0;
            Console.WriteLine("СНИГГЕРС ВВЕДИ ЧИСЛО");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
 
            {
                int a1 = a % 10;
                a = a / 10;
                if (max < a1)
                {
                    max = a1;
                }
            }

            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
