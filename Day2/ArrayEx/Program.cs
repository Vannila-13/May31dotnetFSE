using System;

namespace ArrayEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 4, 3, 2 };
            int[] temp = list;


            // reverse the array
            Array.Reverse(temp);

            foreach (int i in temp)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
