/*Daniel Critchlow Jr*/
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
            //Basic look at arrays and how to manipulate them

            //declare array and form with [], [,], [,,], etc.
            //This is for dimension decliration
            int[,]arr2D = new int[3,3]; //new creates array and [3,3] is the size per dimension

            //using length you can store how many elements are contained in array
            int lengthInFirstDimension = arr2D.GetLength(0);//0 indicates the dimension to check

            Console.WriteLine(lengthInFirstDimension);
        }
    }
}