using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
           {
                { 1,2,3,4,5,6, } ,
                {7,8,9,10,11,12 } ,
                {13, 14, 15,16,17,18 },
                {19,20,21,22,23,24 } ,
                {25 ,26,27,28,29,30 } ,
            };
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
