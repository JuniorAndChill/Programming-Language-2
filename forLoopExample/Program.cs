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
            for(int i = 0; i <=10; i+=2)
            {
                Console.WriteLine(i);
            }
            for(int j = 0; j <= 10; j++)
            {
                if(j==4)
                {
                    Console.WriteLine($"j = {j}");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}