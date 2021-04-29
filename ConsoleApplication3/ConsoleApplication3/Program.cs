using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.70
            int k = Convert.ToInt32(Console.ReadLine());
            double s = 1000;        
            for (int i = 1; i <= 10; i++)
            {
                double s1 = s + s / 100 * 2;
                double ds = s1 - s;
                Console.WriteLine(ds);
                s = s1;
            }
            Console.ReadKey();
        }
    }
}
