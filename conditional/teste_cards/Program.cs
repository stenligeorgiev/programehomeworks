using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a cards or string: ");
            string str = Console.ReadLine();
            switch (str)
            {
                case "2 ":
                case " 3":
                case " 4":
                    Console.Write(" 2,3,4");
                    Console.WriteLine(" Validna  carta ");
                    break;

                case " 5":
                case "  6":
                case " 7":
                    Console.WriteLine(" 5,6,7");
                    Console.WriteLine(" Validna carta");
                    break;
                case "  8":
                case " 9":
                case "10 ":
                    Console.WriteLine(" 8,9,10");
                    Console.WriteLine(" Validna  carta ");
                    break;
                case J;
                case Q;
                case K;
                case A;
                    Console.WriteLine("J,Q ,K ,A");
                    break;


                default:
            }
        }
    }
}

        
    

