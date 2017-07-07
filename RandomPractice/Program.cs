using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////creating a random object
            Random randomNumber = new Random();
            ////saving the random number from our random object (randomNumber)
            int randy = randomNumber.Next(0, 5);
            ////printing out the random int variable
            //Console.WriteLine(randy);
            //Console.WriteLine(randy);
            //Console.WriteLine(randy);
            ////did NOT save that variable to an integer
            //Console.WriteLine(randomNumber.Next(0, 9));

            string[] words = { "Paper", "Rock", "Scissors" };
            int[] numbers = { 1, 2, 3, 76, 6 };
            string sayings = "You can never have to much cake";
            Console.WriteLine(words[randomNumber.Next(0, 3)]);
            Console.WriteLine(numbers[randomNumber.Next(0, 5)]);
            Console.WriteLine(sayings[randomNumber.Next(0, sayings.Length)]);
            
        }
    }
}
