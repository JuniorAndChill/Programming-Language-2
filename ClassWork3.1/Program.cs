/* Daniel Critchlow Jr
Write a program that reads 2 arrays and determines if those arrays
are palindromes. Palindromes are sequences that read the same 
backward as forward. You can declare the array in your code. 
Remember to use the functions we just studied.*/

//I honestly have been keeping these libraries because that was the default for new projects
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
        {
            //1st we input our sample array data to run comparisons
            int[] arr1 = { 1, 2, 3, 2, 1 };
            int[] arr2 = { 1, 2, 3, 3, 2, 1};

            //using bool is more simple decision making and works good in while loops
            bool isArr1Palindrome = IsPalindrome(arr1);
            bool isArr2Palindrome = IsPalindrome(arr2);

            //using bool results we can manipulate the WriteLine easier
            Console.WriteLine($"Is Array 1 palindrome?: {isArr1Palindrome}");
            Console.WriteLine($"Is Array 2 palindrome?: {isArr2Palindrome}");

            //you can have the function call a specific datatype (arr in this case)
            //this will grab any number of arrays that we may add into our program.
            //could have been it's own class as well
            bool IsPalindrome(int[] arr)
            {
                //in C# arrays work differently than C++ so we can run comparisons 
                //without unpacking using for loops. Just set multipoint increments
                int start = 0;
                int end = arr.Length - 1;

                //"while loop" will keep looping till false or meets argument requirement
                while (start < end)
                {
                    if (arr[start] != arr[end])
                    {
                        return false;
                    }
                    //increment both ways to continue comparisons
                    start++;
                    end--;
                }
                return true;
            }
        }
    }
}