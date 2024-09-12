using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4_E2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intialize array to hold values 1-10
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //Outputs array elements through a foreach loop
            Console.Write("All array elements: ");
            foreach (int item in numbers)
            {
                Console.Write($"{item.ToString()} ");
            }
            //Divides space for visibility
            Console.WriteLine("");
            //Outputs sum of array
            Console.WriteLine($"Sum of numbers: {numbers.Sum()}");
            //Outputs largest number in array
            Console.WriteLine($"Largest number: {numbers.Max()}");
            //Outputs smallest number in array
            Console.WriteLine($"Smallest number: {numbers.Min()}");
            //Reverse array elements
            Array.Reverse(numbers);
            //Outputs array in reverse
            Console.Write("Array elements in reverse: ");
            //Calls reverse function to print out each element in numbers array
            reverse(numbers);
            //Divides space for visibility
            Console.WriteLine("");
            //Pauses program to allow user to view
            Console.ReadLine();
        }
        public static void reverse(int[] array)
        {
            //Foreach loop that outputs each element in numbers array with a space between
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
