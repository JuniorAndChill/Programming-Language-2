/*Group practice: Daniel Critchlow, Dylan Ponce*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ForPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Problem 1:
            Create a program that displays the multiplication table of any number*/

            //Get number as input: uNum
            Console.Write("Input a number for the multiplication table: ");
            int uNum1 = int.Parse(Console.ReadLine());

            for(int i =1; i < 11; i++)
            {
                //Multiply 1-10 against the uNum
                int total = uNum1*i;
                //"uNum x 1 = uNum*1" for format
                Console.Write ($"\n{uNum1} x {i} = {total}");
            }
            /*Problem 2:
            Create a program that displays all the multiples of a given number*/

            //question was ambiguous so this was a way to solve this while also not 
            //sure it's 100% the intended deliverable

            //Get number as input: uNum2
            Console.Write("\nInput the upper bound: ");
            int uNum2 = int.Parse(Console.ReadLine());

            //Get number as input: uNum3
            Console.Write("\nInput the multiplier: ");
            int uNum3 = int.Parse(Console.ReadLine());

            //for loop for math based on upperbound input
            for(int i=1; i<uNum2; i++)
            {
                //condition based on % to skip writing incorrect outputs
                if(i%uNum3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            /*Problem 3:
            Create a program that writes a number from 1-999 in words.
            It is acceptable to recieve ten one instead of eleven
            (for all number from 11-19)*/

            //mainly because I find it interesing, I decided to do a switch for this solution
            {
            //get number as input: uNum4
            int uNum4 = 0;
            
            while(uNum4 <= 0)
            {
                Console.Write("\nInput a number between 1-999: ");
                string input =Console.ReadLine();

                if (int.TryParse(input, out uNum4)) 
                {
                    if(uNum4 <= 0)
                    {
                        Console.WriteLine("Please enter a positive integer between 1-999."); 
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a positive integer between 1-999.");
                }
            }
                //place holders for values. I included a teens argument
                int hundreds, tens, teens, ones;
        
                //this will be all the math I need to make my switches work
                hundreds=uNum4/100; 
                tens=uNum4/10%10; 
                ones=uNum4%10; 
                teens=(tens*10)+ones;

                //hundreds was the most simple because we are limiting to 3 max digits 
                    switch(hundreds){
                    case 1:
                        Console.Write("One Hundred ");
                    break;
                    case 2:
                        Console.Write("Two Hundred ");
                    break;
                    case 3:
                        Console.Write("Three Hundred ");
                    break;
                    case 4:
                        Console.Write("Four Hundred ");
                    break;
                    case 5:
                        Console.Write("Five Hundred ");
                    break;
                    case 6:
                        Console.Write("Six Hundred ");
                    break;
                    case 7:
                        Console.Write("Seven Hundred ");
                    break;
                    case 8:
                        Console.Write("Eight Hundred ");
                    break;
                    case 9:
                        Console.Write("Nine Hundred ");
                    break;
                        }
                //i need if statements to activate particular switches when needed
                //i could have also done this with null conditionals "?:"
                if (tens>1){
                switch (tens){
                    case 0:
                        Console.Write("");
                //as was mentioned in class we need to add breaks after every case to make the function stop when we need it to stop
                    break;
                    case 2:
                        Console.Write("Twenty ");
                    break;
                    case 3:
                        Console.Write("Thirty ");
                    break;
                    case 4:
                        Console.Write("Fourty ");
                    break;
                    case 5:
                        Console.Write("Fifty ");
                    break;
                    case 6:
                        Console.Write("Sixty ");
                    break;
                    case 7:
                        Console.Write("Seventy ");
                    break;
                    case 8:
                        Console.Write("Eighty ");
                    break;
                    case 9:
                        Console.Write("Ninty ");
                    break;
                    }
                }
                //i had to set parameters so that teens would only activate when I truely needed them to
                //'if' works for some reason without doing () around the 2 seperate conditions
                if (teens>=10&&teens<100)
                switch (teens){
                    case 10:
                        Console.Write("Ten ");
                    break;
                    case 11:
                        Console.Write("Eleven ");
                    break;
                    case 12:
                        Console.Write("Twelve ");
                    break;
                    case 13:
                        Console.Write("Thirteen ");
                    break;
                    case 14:
                        Console.Write("Fourteen ");
                    break;
                    case 15:
                        Console.Write("Fifteen ");
                    break;
                    case 16:
                        Console.Write("Sixteen ");
                    break;
                    case 17:
                        Console.Write("Seventeen ");
                    break;
                    case 18:
                        Console.Write("Eighteen ");
                    break;
                    case 19:
                        Console.Write("Nineteen ");
                    break;
                    }
                //i needed to make conditions when teens wouldn't activate
                if (teens<10||tens>1){
                switch (ones){
                    case 1:
                        Console.Write("One");
                    break;
                    case 2:
                        Console.Write("Two");
                    break;
                    case 3:
                        Console.Write("Three");
                    break;
                    case 4:
                        Console.Write("Four");
                    break;
                    case 5:
                        Console.Write("Five");
                    break;
                    case 6:
                        Console.Write("Six");
                    break;
                    case 7:
                        Console.Write("Seven");
                    break;
                    case 8:
                        Console.Write("Eight");
                    break;
                    case 9:
                    Console.Write("Nine");
                    break;}
                }
            }

            /*Problem 4:
            Create a program that creates the Fibonacci sequence from 1 to n
            (n = how many steps the seqence progresses. "Up to 'n' values"*/

            //get value
            Console.Write("\nEnter the value of n: "); 
            int n = int.Parse(Console.ReadLine()); 
            //create validation loop
            if (n <= 0) 
            { 
                Console.WriteLine("Please enter a positive integer."); 
                return; 
            }
            //create output prompt 
            Console.WriteLine("Fibonacci sequence up to " + n + ":"); 
            
            //create for loop to iterate values up to the target 'n'
            for (int i = 0; i < n; i++) 
            {
                    //"?" is a null conditional operator which allows for 
                    //passing of possible null values without explicitly 
                    //checking for null 1st. Allows for returning null instead
                    //of throwing a runtime exception. This will add a comma when
                    //needed without needing to create an if loop to check if one
                    //is necessary
                    Console.Write(Fibonacci(i) + (i < n - 1 ? ", " : "")); 
            } 
            
            //create method for Fibonacci math
            static int Fibonacci(int n) 
            { 
                if (n <= 1) 
                return n; 
                //return values that plug into the iteration loop above the method
                return Fibonacci(n - 1) + Fibonacci(n - 2); 
            } 
        }
    }
}