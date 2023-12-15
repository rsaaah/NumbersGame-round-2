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
            Console.WriteLine("Welcome! Guess the Correct number from 1-10, you have five tries");

            // Generates a random number from 1-10
            Random correctNum = new Random();
            int number = correctNum.Next(1, 11);      
            
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
                    attempts++;

                    if (number == userNum)
                    {
                        // Tells user their number is correct
                        Console.WriteLine("That's the right number!");
                        Console.WriteLine($"Attemps taken: {attempts}/5");
                        break;
                        
                    }
                    else if (userNum < number)
                    {
                        // Tells user their number is lower than correct number
                        Console.WriteLine("Invalid number.That Number is too low! Enter a valid number from 1-10!");
                        Console.WriteLine($"Attemps taken: {attempts}/5");
                    }
                    else
                    {
                        // Tells user they are higher than correct number
                        Console.WriteLine("Invalid Number.That Number is too high. Enter a valid number from 1-10!");
                        Console.WriteLine($"Attemps taken: {attempts}/5");
                    }
                }
                else
                {
                    // Tells user they input an invalid number to try again
                    Console.WriteLine("Invalid entry. Enter a valid number from 1-10!");
                }
                    
                if (attempts == maxAttempts)
                {
                    // Tells user they guessed too many times
                    Console.WriteLine($"Sorry you are out of attempts. The correct number was {number}.");
                }
            }

            

            




        }
    }
}
