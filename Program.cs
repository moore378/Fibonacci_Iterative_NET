using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Iterative_NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Fib_Iter(10);
        }

        public static void Fib_Iter(int len)
        {
            int a=0, b=1, c = 0;
            Console.Write($"{a} {b}");

            for(int x=2; x<len; x++)
            {
                c = a + b;
                Console.Write($" {c}");

                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
}
