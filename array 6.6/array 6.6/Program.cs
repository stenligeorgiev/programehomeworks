﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            
            int length = array.Length;
           
            int[] reversed = new int[length];
         
              for (int index = 0; index < length; index++)
              {
                reversed[length - index - 1] = array[index];
              }
           
               for (int index = 0; index < length; index++)
               {
                Console.Write(reversed[index] + " ");
               }
        }
    }
}    







    

