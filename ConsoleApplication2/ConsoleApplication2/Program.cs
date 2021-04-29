using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.67 a
            Console.WriteLine("ЙОУ СНИГГЕРС НОМЕР ЭЛЕМЕНТА");
            int k = Convert.ToInt32(Console.ReadLine());
            int a1 = 1;
            int a2 = 1; 
            for (int i = 3; i<=k; i++)
            {                
                int a = a1 + a2;
                a1 = a2;
                a2 = a;
            }
            Console.WriteLine("Элемент № "+k+" равен " +a2);
            Console.ReadKey();
        }
    }
}

