using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the number a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter  the  number b:");
            int b = int.Parse(Console.ReadLine());
            int[,] intMatrix = new int[3, 4];








            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
    }
}
