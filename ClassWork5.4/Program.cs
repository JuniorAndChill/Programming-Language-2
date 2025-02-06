/* Daniel Critchlow Jr*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4) Read an array of n numbers and check if all the values are consecutive.*/
            
            //get input to find out how many values we will compare
            Console.Write ("\nHow many values are we counting?: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //initialize bool...pretty sure it's better practice to 
            //init in false but can't remember atm
            bool consecutive = true;

            //create array to store values for comparison
            int [] num = new int [n];

            //for loop to access array and store the inputs
            for(int i = 0; i < n; i++)
            {
                Console.Write("\nGive me value #" + (i+1) + " : ");
                int reps= Convert.ToInt32(Console.ReadLine());
                num [i] = reps;
            }
            
            //second for loop to compare and set new bool state
            for(int i = 0; i < n-1; i++){
                //comparison of current element value against same value +1
                //basically "is 3+1 == 4?"
                if(num[i] + 1 != num[i+1])
                {
                    //if not the it's false
                    consecutive = false;
                }
            }
            //we need to check the opposite sequence
            //this is only active if 1st check fails
            //obviously if it was true then the opposite is false...
            if(!consecutive){
                //RE-INITIALIZE!!!!!! Otherwise you fail successfully
                consecutive = true;
                //access array again but...
                for(int i = 0; i < n-1; i++)
                {
                    //...this time [i]-1 because opposite direction
                    if(num[i]-1 != num[i+1]){
                        consecutive = false;
                    }
                }
            }
            //placement is important. If in loop it'll print on every check. It's weird like that
            Console.Write("\nThe values consecutive?: " + consecutive);
        }
    }
}