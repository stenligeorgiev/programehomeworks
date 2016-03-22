using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cikli5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberone = Console.ReadLine();
            int num1 = int.Parse(numberone);
            string numbertwo = Console.ReadLine();
            int num2 = int.Parse(numbertwo);
            long sum = 0;
            
            sum = num1 + num2;
            for (int i = 0; i < sum; i++)
            {
                if (num1> 0 && num2>0)
                {
                    Console.WriteLine(sum);
                }
                else
                {
                    break;
                }
            }
            
             
          
            
               
              

               
            
         

           
          

           
           
            
         
           

           
            
        }
    }
}
