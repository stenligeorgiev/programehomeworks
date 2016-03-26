using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metod1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 7;
            PrintSborNumber (a, b);

        }

        private static void PrintSborNumber(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }
    }
}
