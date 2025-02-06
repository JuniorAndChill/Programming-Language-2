/* Daniel Critchlow Jr*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*3) Write a program that reads n numbers (up to a maximum of 20) 
            and counts how many times the number 11 appears in the array. */

            //get input 1-20
            Console.Write("\nGive me the reps (1-20): ");

            //convert value to int from string
            int n = Convert.ToInt32(Console.ReadLine());

            //intialize count
            int count = 0;
            //create array to store user inputs
            int [] num = new int [n];

            //for loop to store the user inputs as they enter them
            for(int i = 0; i < n; i++)
            {
                Console.Write("\nGive me a number: ");
                int reps = Convert.ToInt32(Console.ReadLine());
                num[i] = reps;
            }
            //second for loop for comparing values to "11" and adding to count
            for(int i = 0; i < n; i++)
            {
                //when the value == 11 then up the count
                if(num[i] == 11){
                    count++;
                }
            }
            //print the count 
            Console.Write("\nThe number 11 is repeated " + count + " times.");
        }
    }
}