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
            // 5.39 
            int s = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("йоу ниггер тут нужно твое число");
                int a = Convert.ToInt32(Console.ReadLine());
                s = s + a; 
            }
            Console.WriteLine("s=" + s);
            Console.ReadKey();
        }
    }
}
