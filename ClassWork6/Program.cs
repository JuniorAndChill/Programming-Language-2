/* Daniel Critchlow Jr
Create a program that determines how many different ways that 
I can arrange a certain number of items (r) from a larger 
collection (n)*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork6
{
    internal class Program
    {
        static int Factorial(int num)
        {
            //i set up the multiplication to 1 for the loop
            int result = 1;
            for(int i = 2; i <= num; i++)
            {
                //when it iterates multiply the result to the index
                result *= i;
            }
            //just checking if the math is right with a print
            Console.WriteLine(result);
            //return the math for later
            return result;
        }
        static void Main(string[] args)
        {
            //set vars for math
            Console.Write("Give me the group size: ");
            int g = int.Parse(Console.ReadLine());

            Console.Write("Give me the size of each team: ");
            int r = int.Parse(Console.ReadLine());

            //the 1.0 allows for more accurate math from our function
            Console.WriteLine(1.0*Factorial(g)/Factorial(g-r));
        }
    }
}