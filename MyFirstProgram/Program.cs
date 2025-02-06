/*Daniel Critchlow Jr.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Create a program that reads an email and displays the username and domain name.
            Input: 
            Give me your email: delriogu@uiwtx.edu
            Output: 
            The username is delriogu
            The domain name is uiwtx.edu*/
            

            //take input from user
            Console.WriteLine("Input your email: ");
            
            //once you take in the string store it here
            string email = Console.ReadLine();

            //using .IndexOf find the location of @ and store it to reference later
            int charPos = email.IndexOf('@');

            //domain names are everything after @ in emails, store it here
            string domainName = email.Substring(charPos+1); //substring over by 1 from the location of the @

            //user names are everything before the @, store it here
            string userName = email.Substring(0, charPos); //substring from the start of the string until @

            /*good to remember that strings are arrays of chars in a line. So just like arrays, positions start
            from 0 -> infinite -1 (or limit of container -1). So if you are counting in an array;
            normal math is 1, 2, 3, 4, 5 for example and "array math" is 0, 1, 2, 3, 4 . Both count to 5*/

            //print your statement. "$" allows you for inline formatting instead of using "+" and extra quotation marks
            //normal example: Console.WriteLine("Your user name is: " + userName + " and your domain is: " + domainName);
            Console.WriteLine($"Your user name is: {userName} and your domain is: {domainName}");
            Console.ReadLine();
        }
    }
}