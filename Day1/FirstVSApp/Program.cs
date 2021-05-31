using System;

namespace FirstVSApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum;
            num1 = 50;
            num2 = 100;
            sum = num1 + num2;
            Console.WriteLine($"The Sum is {sum}");
            Console.WriteLine("Learn Selection");//if statement
            if(num1==num2)
             Console.WriteLine("The numbers are equal");

                else if (num1 > num2)
                    Console.WriteLine($"{num1}  which is num1 is greater");
                else
                    Console.WriteLine($"{num2} which is num2 is greater");
            Console.WriteLine("Learn Iteration");//for loop
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(i);
             }
            int count = 0;//while statement
            while(count<100)
            {
                Console.WriteLine(count);
                count = count + 10;
            }
            int n = 0;
            do
            {
                Console.WriteLine("tick" + n);
                n++;
            } while (n < 10);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
