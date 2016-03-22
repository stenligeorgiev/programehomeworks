using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklite5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.WriteLine("  Please  enter  integer number :");
            bool isnInt = int.TryParse(Console.ReadLine(), out n);
            for (int i = 1; i < 100; i++)
            {
                if (i % 7 ==0 )
                {
                    Console.WriteLine(i);
                }
                if (i % 11 == 0 )
                {
                    Console.WriteLine(i);
                }
            
            

            }
        }
    }
}
