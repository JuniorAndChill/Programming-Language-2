/*Daniel Critchlow Jr.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forLoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*"for" loops is generally how you access arrays by using a temp
            value "i for index" for example, setting a range "from i to 10 or less",
            and "advance count by number" (2 in this case below)*/
            for(int i = 0; i <=10; i+=2)
            {
                //using "i" as a placeholder so to speak, we print the value located in the spot
                Console.WriteLine(i);
            }
            for(int j = 0; j <= 10; j++)
            {
                //you can nest other loops or checks while searching through your array
                if(j==4) //"once the index is on 4, do this"
                {
                    //this prints the letter and it's positon
                    Console.WriteLine($"j = {j}");
                    //"break" to exit the current loop
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}