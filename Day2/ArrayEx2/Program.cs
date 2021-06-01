using System;

namespace ArrayEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please the size of the array");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[length];
            int counter = 0;
            string strChoice = "";
            Console.WriteLine("Please enter the words and enter no if you wish to exit.");
            Console.WriteLine($"You can enter the maximum of {length} words.");
            do
            {
                strChoice = Console.ReadLine();
                words[counter] = strChoice;
                counter++;

            } while (strChoice != "No" && counter <= words.Length);
            Console.WriteLine("You have enter the following words");
            for(int i=0;i<words.Length;i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.ReadKey();

        }
    }
}
