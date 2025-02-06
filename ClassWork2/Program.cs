/*Daniel Critchlow Jr*/
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Given a three-digit number, switch the digits. You must assign the switched digits to an integer variable. 
            Then, the user inputs another number that will be added. To solve this problem you will only need to use simple 
            expressions with basic numeric operators.
                Input:
                Give me the number: 827
                Give me a number to add: 10
                Output:
                The new number is: 738
                Input:
                Give me the number: 34
                Give me a number to add: 100
                Output:
                The new number is: 530*/
                            

            /*I flipped the operations and worked around the intended result. Here's
            The actual way I was supposed to accomplish this instead;*/

            //take string and store/convert to int
            Console.Write("Give me a three digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //simplest answer is best here. EZPZ maths
            int hunds = number/100;
            int tens = number/10%10;
            int ones = number%10;

            //since its broken up you can reverse the maths after flipping and add
            int flippedNum = (ones*100) + (tens*10) + hunds;

            //take in new string and store/convert to int
            Console.Write("Give me a number to add: ");
            int addNum = Convert.ToInt32(Console.ReadLine());

            //add the values for intended result as a single int
            int total = flippedNum + addNum;
            Console.WriteLine($"The final number is: {total}");
            


            /*To solve this second problem, you might need casting. Given a lowercase letter and a 
            number between 0 and 26, return that letter Caesar shifted by that number. To Caesar 
            shift a letter by a number, advance it in the alphabet by that many steps, wrapping 
            around from z back to a:
            
            Example:
            Caesar('a', 0) => 'a'
            Caesar ('a', 1) => 'b'
            Caesar ('a', 5) => 'f'
            Caesar ('a', 26) => 'a'
            Caesar ('d', 15) => 's'
            Caesar ('z', 1) => 'a'
            Caesar ('q', 22) => 'm'

            Input:
            Give me the letter: f
            Give me the number: 3

            Output:
            The Caesar shift is: i*/

            //take input for a letter
            Console.Write("\nGive me a letter: ");

            //to ensure the characters are lower case use .ToLower and use .KeyChar to unlock Unicode
            char letter = char.ToLower(Console.ReadKey().KeyChar);
            
            //take shift value and use .Parse to convert to int
            //***interesting note about .Parse vs Convert. ; .Parse is when you expect to get valid integers.
            //you use Convert. when you may get unexpected values such as "Null". If a value goes through
            //that can't convert into an integer, you will get "0".  Keep it in mind***
            Console.Write("\nEnter shift (0-25): ");
            int shift = int.Parse(Console.ReadLine());

            //this set of functions compares unicode alphabet to the spaces you want to move a-z
            int charValue = letter - 'a';
            int shiftedValue = (charValue + shift) % 26;

            //"(char)(shiftedValue + 'a')" displays result as a letter. Otherwise it would be Unicode result
            Console.WriteLine("Shifted letter: "+ (char)(shiftedValue + 'a'));
            
            Console.ReadLine();
        }
    }
}