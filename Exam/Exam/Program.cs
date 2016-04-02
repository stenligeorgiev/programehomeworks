using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {



            
            
              
            

            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[ n, n ];
            

            
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }










        }
    }
}
