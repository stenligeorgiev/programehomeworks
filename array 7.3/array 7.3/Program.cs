using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[,] Matrix = new int[2, 4];
            Console.WriteLine("Enter the cells of the matrix:");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    Matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    Console.Write(Matrix [row, col]);
                }
                Console.WriteLine();
            }


        }
    }
}
