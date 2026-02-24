using System;

namespace Random_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random(553624324);
            int randNum;    //Random num in this variable
            randNum = generator.Next(10);

            Console.WriteLine("My random number is " + randNum);
            Console.WriteLine("Here are some numbers from 0 to 4!");
            Console.Write(generator.Next(1, 6) + " ");
            Console.Write(generator.Next(1, 6) + " ");
            Console.Write(generator.Next(1, 6) + " ");
            Console.Write(generator.Next(1, 6) + " ");
            Console.Write(generator.Next(1, 6) + " ");
            Console.WriteLine(generator.Next(1, 6) + " ");
            Console.WriteLine();
            Console.WriteLine("Here are some numbers from 0 to 99!");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.WriteLine(generator.Next(100) + " ");
            Console.WriteLine();
            int num1 = generator.Next(10);
            int num2 = generator.Next(10);
            if (num1 == num2)
            {
                Console.WriteLine("The random numbers were the same! Weird.");
            }
            if (num1 != num2)
            {
                Console.WriteLine("The random numbers were different! Not weird. ");
            }
            Console.ReadLine(); // Keeps the program from quitting









            int max, min;
            Console.WriteLine("Provide a maximum value: ");
            max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Provide a minimum value");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here is a random number between " + min + " and " + max + ": ");
            Console.WriteLine(generator.Next(min, max + 1));


        }
    }
}