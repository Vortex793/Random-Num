
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Random_Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randNum;    //Random num in this variable
            randNum = generator.Next(10);

            //Console.WriteLine("My random number is " + randNum);
            //Console.WriteLine("Here are some numbers from 0 to 4!");
            //Console.Write(generator.Next(1, 6) + " ");
            //Console.Write(generator.Next(1, 6) + " ");
            //Console.Write(generator.Next(1, 6) + " ");
            //Console.Write(generator.Next(1, 6) + " ");
            //Console.Write(generator.Next(1, 6) + " ");
            //Console.WriteLine(generator.Next(1, 6) + " ");
            //Console.WriteLine();
            //Console.WriteLine("Here are some numbers from 0 to 99!");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.Write(generator.Next(100) + " ");
            //Console.WriteLine(generator.Next(100) + " ");
            //Console.WriteLine();
            //int num1 = generator.Next(10);
            //int num2 = generator.Next(10);
            //if (num1 == num2)
            //{
            //    Console.WriteLine("The random numbers were the same! Weird.");
            //}
            //if (num1 != num2)
            //{
            //    Console.WriteLine("The random numbers were different! Not weird. ");
            //}
            //Console.ReadLine(); // Keeps the program from quitting









            //int max, min;
            //Console.WriteLine("Provide a maximum value: ");
            //max = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Provide a minimum value");
            //min = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Here is a random number between " + min + " and " + max + ": ");
            //Console.WriteLine(generator.Next(min, max + 1));



            //int guess, secretNumber;
            //secretNumber = generator.Next(1, 11);
            //Console.WriteLine("Guess the secret number. It could be anything from 1 to 10");
            //guess = Convert.ToInt32(Console.ReadLine());
            //if (guess == secretNumber)
            //    Console.WriteLine("Congradulations, you guessed it!!");
            //else
            //    Console.WriteLine("Sorry but no, the secret number was " + secretNumber + " and not " + guess);

            //int num1, num2, total ;
            //Console.WriteLine("Press ENTER to roll the dice");
            //Console.ReadLine() ;
            //num1 = generator.Next(1, 7);
            //num2 = generator.Next(1, 7);
            //total = num1 + num2;
            //Console.WriteLine("Die 1 = " + num1);
            //Console.WriteLine("Die 2 = " + num2);
            //Console.WriteLine("Total = " + total);



            int response = generator.Next(6);
            Console.WriteLine("Welcome to the future-seer 3000.  Please ask your yes/no question:");
            Console.ReadLine() ;
            Thread.Sleep(500);
            if (response == 0)
                Console.WriteLine("Yes, definitely!");
            else if (response == 1)
                Console.WriteLine("Ask again later");
            else if (response == 2)
                Console.WriteLine("No way!");
            else if (response == 3)
                Console.WriteLine("The future is hazy, I can't tell");
            else if (response == 4)
                Console.WriteLine("There is a high probability of it being so.");
            else
                Console.WriteLine("Outlook not so good.");



        }

    }
}