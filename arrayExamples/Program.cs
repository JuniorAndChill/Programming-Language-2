using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,]arr2D = new int[3,3];
            int lengthInFirstDimension = arr2D.GetLength(0);
            Console.WriteLine(lengthInFirstDimension);
        }
    }
}