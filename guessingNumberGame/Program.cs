using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace guessingNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);

            Console.WriteLine("Welcome to the number guessing game!" );
            Console.WriteLine("A number between 1 and 10 will be generated." );
            Console.WriteLine("If you guess the correct number, you win!");

            while (!isCorrectGuess)
            {
                Console.WriteLine("Please enter your guess");
                int guess = int.Parse(Console.ReadLine());

                if (guess > randomNum)
                {
                    Console.WriteLine("guess is too high");
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("guess is too low");
                }
                else if ( guess == randomNum){
                    isCorrectGuess = true;
                    Console.WriteLine("Your guess is correct");
                    Console.WriteLine("YOU WIN!");  
                    Console.ReadLine();
                }
                else {
                    Console.WriteLine("ERROR, TRY AGAIN");
                }

                
                
            }
           
            

        }
    }
}
