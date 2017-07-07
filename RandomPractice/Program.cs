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
            //creating a random object
            Random randomNumber = new Random();
            //saving the random number from our random object (randomNumber)
            int randy = randomNumber.Next(0, 5);
            //printing out the random int variable
            Console.WriteLine(randy);
            Console.WriteLine(randy);
            Console.WriteLine(randy);
            //did NOT save that variable to an integer
            Console.WriteLine(randomNumber.Next(0, 9));

            
        }
    }
}
