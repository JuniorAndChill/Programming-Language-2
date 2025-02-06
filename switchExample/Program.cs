/*Daniel Critchlow Jr*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Read a number and indicate what month it is using a switch*/
            
            //take and convert input to integer 
            Console.Write("Input a number between 1 - 12 to find month: ");
            int month = int.Parse(Console.ReadLine());

            //declare swith and check against "month" value
            switch(month)
            {
                //case checks for matching value "month == 1" for example
                //when match is found it displays message only after the process
                //gets kicked out from "break;" statement. Exits current loop
                case 1:
                Console.WriteLine("January");
                break;
                case 2:
                Console.WriteLine("Feburary");
                break;                
                case 3:
                Console.WriteLine("March");
                break;                
                case 4:
                Console.WriteLine("April");
                break;                
                case 5:
                Console.WriteLine("May");
                break;                
                case 6:
                Console.WriteLine("June");
                break;                
                case 7:
                Console.WriteLine("July");
                break;                
                case 8:
                Console.WriteLine("August");
                break;                
                case 9:
                Console.WriteLine("September");
                break;                
                case 10:
                Console.WriteLine("October");
                break;                
                case 11:
                Console.WriteLine("November");
                break;                
                case 12:
                Console.WriteLine("December");
                break;
                //default adds a form of error handeling
                default:
                Console.WriteLine("Wrong Number");
                break;
            }
            Console.ReadLine();
        }
    }
}