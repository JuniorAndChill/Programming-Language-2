/*Daniel Critchlow Jr.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MethodExample
{
    internal class Program
    {
        //methods are functions that are outside of "void Main"
        //typically to be called multiple times. Makes code readable
        static void MyMethod()//in c# typically you use Pascal case (c++ is camel)
        {
            Console.WriteLine("I just got excecuted");
        }
        static void PrintNum(int num)
        {
            Console.WriteLine(num);
        }
        static void PrintsNumbers(int num1, int num2, int num3)
        {
            //Console.WriteLine(num1+num2+num3);
            int result = num1 + num2 + num3;
            //here we can see you can call a method into a method and get results
            Adding(result);
        }
        static void Adding(int num)
        {
            Console.WriteLine(num+2);
        }
        static void MyDef(string country = "Norway")
        {
            //This example shows a way you can pass a default value if nothing was called
            Console.WriteLine(country);
        }
        static int AddNum(int num4, int num5)
        {
            return num4+num5;
        }
        static void Main(string[] args)
        {
            //using methods I can manipulate main easier
            Console.WriteLine("This is a single use of my method");
            MyMethod();

            Console.WriteLine("\nThis is an example of looped use");
            for(int i = 0; i < 5; i++)
            {
                MyMethod();
            }

            Console.WriteLine("\nThis is an example passing values");

            PrintNum(5);

            int num1 = 3, num2 = 4, num3 =7;
            Console.WriteLine("\nThis is an example with multiple values");

            PrintsNumbers(num1,num2,num3);

            Console.WriteLine("\nThis is an example of setting default values (Norway is default)");
            MyDef("India");
            MyDef("Sweden");
            MyDef();
            MyDef("USA");

            if(AddNum(3,4)==7)
            {
                Console.WriteLine("\nThis is correct");
            }

            Console.ReadLine();
        }
    }
}