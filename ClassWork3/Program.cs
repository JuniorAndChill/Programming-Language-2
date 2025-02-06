/*Version on ClassWork3 that lab partner turned in*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        
        //C# Program Problem #1 


        {
            Console.Write("Enter a number: "); 
            int number = int.Parse(Console.ReadLine()); 
            for (int i = 1; i <= 10; i++) 
            { 
                Console.WriteLine($"{number} x {i} = {number * i}"); 
            } 
        } 

        C# Program Problem #2 
        using System; 
        class Program 
        { 
            static void Main() 
            {
                Console.Write("Enter a number: "); 
                int number = int.Parse(Console.ReadLine()); 
                Console.WriteLine("Multiples of " + number + ":");

                for (int i = 1; i <= number; i++) 
                { 
                    if (number % i == 0) 
                    { 
                        Console.WriteLine(i); 
                    } 
                } 
            } 
        } C# Program Problem #3 
        using System; 
        class Program 
        { 
            static void Main() 
            { 
                Console.Write("Enter a number (1-999): "); 
                int number = int.Parse(Console.ReadLine()); 
                if (number < 1 || number > 999) 
                { 
                    Console.WriteLine("Number out of range."); 
                    return; 
                } 
                    Console.WriteLine(NumberToWords(number)); 
            } 
                static string NumberToWords(int number) 
                { 
                    if (number == 0) return "zero"; 
                    if (number < 0) return "minus " + NumberToWords(Math.Abs(number)); 
                    string words = ""; 
                    if ((number / 100) > 0) 
                    { 
                        words += NumberToWords(number / 100) + " hundred "; number %= 100; 
                    } 
                    if (number > 0) 
                    { 
                        if (words != "") words += "and "; 
                        var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "ten one", "ten two", "ten three", "ten four", "ten five", "ten six", "ten seven", "ten eight", "ten nine" }; 
                        var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" }; 
                        if (number < 20) words += unitsMap[number]; 
                        else 
                        { 
                            words += tensMap[number / 10]; 
                            if ((number % 10) > 0) words += " " + unitsMap[number % 10]; 
                        } 
                    } 
                    return words.Trim(); 
                } 
            } 
            C# Program Problem #4 
            using System; 
            class Program 
            {
                static void Main() 
                { 
                    Console.Write("Enter the value of n: "); 
                    int n = int.Parse(Console.ReadLine()); 
                    if (n <= 0) 
                    { 
                        Console.WriteLine("Please enter a positive integer."); 
                        return; 
                    } 
                    Console.WriteLine("Fibonacci sequence up to " + n + ":"); 
                    for (int i = 0; i < n; i++) 
                    {
                         Console.Write(Fibonacci(i) + (i < n - 1 ? ", " : "")); 
                    } 
                } 
                static int Fibonacci(int n) 
                { 
                    if (n <= 1) 
                    return n; 
                    return Fibonacci(n - 1) + Fibonacci(n - 2); 
                } 
            } //Dylan Ponce, Daniel Critchlow//