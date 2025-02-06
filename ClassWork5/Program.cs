/* Daniel Critchlow Jr*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2) Write a program that reads n numbers (up to a maximum of 20)
            and determines how many times the last number appears*/

            //get input 1-20
            Console.Write("\nGive me the reps (1-20): ");

            //convert value to int from string
            int n = Convert.ToInt32(Console.ReadLine());

            //intialize count. How we keep track of our target
            int count = 0;
            
            //create array to store user inputs
            //it will also be a reference later for the range in the "for" loop
            int [] num = new int [n];

            //for loop to store the user inputs as they enter them
            for(int i = 0; i < n; i++)
            {
                //take input and convert to integer, place integers into the index 1 by 1 
                Console.Write($"\nGive me value #{i+1}: ");
                int reps = Convert.ToInt32(Console.ReadLine());
                num[i] = reps;
            }
            //second for loop for comparing values and adding to count        
            for(int i = 0; i < n; i++)
            {
                //this compares the current index to the last index of the array
                if(num[i] == num[n-1])
                {
                    //when it finds a match you at to your counter
                    count++;
                }
            }
            Console.Write($"\nThe number {num[n-1]}, is repeated {count} time(s)");
        }
    }
}