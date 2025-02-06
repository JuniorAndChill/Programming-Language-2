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
            
            //take the input string and convert to integer
            //using "Write" instead of "WriteLine" allows for multiple inputs without interuption
            Console.Write("Input a number to determine multiples against: ");
            int uNumber1 = int.Parse(Console.ReadLine());

            //take and convert second value
            Console.Write("Input another number to check if multiple: ");
            int uNumber2 = int.Parse(Console.ReadLine());

            //"if else" statements to determine "if multiple", "if opposite is multiple", and "if not"
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
            
            //Console.RL to finish displaying result
            Console.ReadLine();
        }
    }
}