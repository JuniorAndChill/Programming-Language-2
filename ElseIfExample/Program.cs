/*Daniel Critchlow Jr*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseIfExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Read 2 numbers and indicate if they are multiples of each other
                i.e. 4 is a multiple of 8
                i.e. 2 is not a multiple of 5*/
            
            //take the input 
            Console.Write("Input a number: ");
            int uNumber1 = int.Parse(Console.ReadLine());
            Console.Write("Input another number: ");
            int uNumber2 = int.Parse(Console.ReadLine());
            if(uNumber1%uNumber2==0)
            {
                Console.WriteLine(uNumber1 + " is a multiple of " + uNumber2 + ".");
            }
            else if(uNumber2%uNumber1==0)
            {
                Console.WriteLine(uNumber1 + " is a multiple of " + uNumber2 + ".");
            }
            else
            {
                Console.WriteLine("These are not multiples.");
            }
            
            Console.ReadLine();
        }
    }
}