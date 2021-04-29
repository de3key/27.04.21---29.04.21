using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.22
           
            Console.WriteLine("СНИГГЕРС ВВЕДИ ЧИСЛО");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            while (a!=0)
            {
                int a1 = a % 10;                
                a = a / 10;
                if (a1 == 3)
                {
                 n = n + 1;
                }
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
