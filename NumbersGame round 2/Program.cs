using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGame_round_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Guess the Correct number, you have five tries");

            // Generates a random number from 1-10
            Random correctNum = new Random();
            int number = correctNum.Next(1, 10);      
            
            // This is to test the random number output
            Console.WriteLine(number);

            // Generates number of attempts for user
            int attempts = 0;
            int maxAttempts = 5;
            
            while (attempts < maxAttempts)
            {
                Console.WriteLine("Enter your guess: ");
                // checks if input is a valid number
                
                if (int.TryParse(Console.ReadLine(), out int userNum))
                {

                    if (number == userNum)
                    {
                        // Tells user their number is correct
                        Console.WriteLine("That's the right number!");
                        break;
                    }
                    else if (userNum < number)
                    {
                        // Tells user their number is lower than correct number
                        Console.WriteLine("That Number is too low!");
                    }
                    else if (userNum > number)
                    {
                        // Tells user they are higher than correct number
                        Console.WriteLine("That Number is too high!");
                    }
                }
                    attempts++;
                if (attempts == maxAttempts)
                {
                    // Tells user they guessed too many times
                    Console.WriteLine($"Sorry you are out of attempts. The correct number was {number}.");
                }
            }

            

            




        }
    }
}
