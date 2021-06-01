using System;

namespace SparseArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            // Declare second integer, double, and String variables.
            float num3 = 4f ,num4 = 4f;
           
            // Read and save an integer, double, and String to your variables.
            num1 = 4;
            num2 = 12;
            // Print the sum of both integer variables on a new line.
            int sum1 = 0;
             sum1 = num1 + num2;
            Console.WriteLine(sum1);
            // Print the sum of the double variables on a new line.
            float sum2 = 0;
            sum2 = num3 + num4;
           
            Console.WriteLine($"{sum2}");
            //Console.WriteLine(sum2);
            // Concatenate and print the String variables on a new line
            string text = "is the best place to learn and practice coding!";
            // The 's' variable above should be printed first.
            string name = $"HackerRank {text} ";
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}




