using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame_round_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Guess the Correct number, you have five tries");

            // Generates a random number from 1-20
            Random correctNum = new Random();
            int number = correctNum.Next(1, 20);

            // Hides the random number

            string guessNum = Console.ReadLine();
            int.TryParse(guessNum, out int userNum);

            Console.WriteLine(number);

            // Generates number of attempts for user
            
            // Tells user they are higher than correct number


            if (number == userNum)
            {
                // Tells user their number is correct
                Console.WriteLine("That's the right number!");
            }
            else if (userNum < number)
            {
                // Tells user their number is lower than correct number
                Console.WriteLine("Number is too low!");
            }




        }
    }
}
