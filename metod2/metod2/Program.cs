using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 7;
            int c = 4;

            int razlica = CalculateRaz(a, b, c);
            Console.WriteLine(razlica);
        }

        private static int CalculateRaz(int a, int b, int c)
        {
            return a - b - c;
        }
    }
}
