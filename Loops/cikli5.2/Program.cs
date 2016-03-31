using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cikli5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("  Please  enter  integer number :");
            bool isnInt = int.TryParse(Console.ReadLine(), out n);
            if (isnInt)
            {
                for (int i = 1; i <= n; i++)
                {

                    if (i % (3 * 7) == 0)
                    {
                        Console.WriteLine(" Please enter  number:");
                    }
                }
            }
        }
    }