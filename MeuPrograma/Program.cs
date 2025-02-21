using System;
using System.Text;

namespace MeuPrograma
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello LP1!");
            Console.WriteLine("Bye world");
            Console.WriteLine("Hello LP1!");
            int i = 1;
            uint j = 1U;
            Console.WriteLine(i + " " + j);
            char copyrightSymbol = '\u009A';
            char omega = '\u03A9';
            Console.WriteLine(copyrightSymbol + " " + omega);
            double x = 3.1415;
            float y = 3.1415f;
            decimal z = 3.1415m;
            long k = 3L;
            ulong n = 3UL;
            Console.WriteLine(x + " " + y + " " + z + " " + k + " " + n);
        }
    }
}
