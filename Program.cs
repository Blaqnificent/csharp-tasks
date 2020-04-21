using System;
using System.Collections.Generic;


namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collect user's name and level they would like to play at

            List<string> levels = new List<string> {"Easy: 6 guesses. Number betweeen 1 and 10", "Medium: 4 Guesses. Number between 1 and 20", "Hard: 3 Guesses. Number between 1 and 50"};
            Console.Write("Welcome to the number guessing game! \nWhat is your name? : ");
            string usrName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"Hi, {usrName}. Please choose a level from the options below: \n");
            int count = 1;
            
            foreach(string level in levels) // Prints out the game level options available for the user to pick.
            {
                Console.WriteLine($"{count} = {level}");
                count++;
            }
            
            Console.Write("\nEnter either '1', '2', or '3' : "); 
            int usrChoice = Convert.ToInt32(Console.ReadLine()); //Converts user's choice to an integer. 
            bool gameStatus = true;
            Random randomNumber = new Random(); //Creates a Random class to generate random numbers from.
            
            //Main program
            while (gameStatus)
            {
                if (usrChoice == 1) //Easy user choice loop.
                {
                    int randEasy = randomNumber.Next(1, 10); //random number between 1 and 10.
                    int guessCount = 6; //Number of guesses for this level
                    int usrGuess;
                    while (guessCount > 0)
                    {
                        Console.Write($"You've got {guessCount} guess(es). Enter your guess here: ");
                        try
                        {
                            //Check for incorrect input errors.
                            usrGuess = Convert.ToInt32(Console.ReadLine());
                            if (usrGuess == randEasy)
                            {
                                Console.WriteLine($"You got it right! Your guess is {usrGuess}");
                                gameStatus = false; //Ends game loop.
                                break; //Exits guess loop.
                            }
                            else if (usrGuess != randEasy)
                            {
                                Console.WriteLine("That was wrong.");
                                guessCount -=1;
                                if (guessCount == 0)
                                {
                                    Console.WriteLine("You've got no more guesses left. Game over!");
                                    gameStatus = false;
                                    break;
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Error. Please enter a whole number");
                        }
                        
                    }
                }
                else if (usrChoice == 2) // Medium game level choice loop. 4 guesses, random number between 1 and 20.
                {
                    int randMedium = randomNumber.Next(1, 20);
                    int guessCount = 4;
                    int usrGuess;

                    while (guessCount > 0)
                    {
                        Console.Write($"You've got {guessCount} guess(es). Enter your guess here: ");
                        try
                        {
                            //Check for incorrect input errors.
                            usrGuess = Convert.ToInt32(Console.ReadLine());
                            if (usrGuess == randMedium)
                            {
                                Console.WriteLine($"You got it right! Your guess is {usrGuess}");
                                gameStatus = false;
                                break;
                            }
                            else if (usrGuess != randMedium)
                            {
                                Console.WriteLine("That was wrong.");
                                guessCount -=1;
                                if (guessCount == 0)
                                {
                                    Console.WriteLine("You've got no more guesses left. Game over!");
                                    gameStatus = false;
                                    break;
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Error. Please enter a whole number");
                        }

                    }
                        
                }
                else if (usrChoice == 3) // Hard game level choice. 3 guesses, random number between 1 and 50
                {
                    int randHard = randomNumber.Next(1, 50);
                    int guessCount = 3;
                    int usrGuess;
                    while (guessCount > 0)
                    {
                        Console.Write($"You've got {guessCount} guess(es). Enter your guess here: ");
                        try
                        {
                            usrGuess = Convert.ToInt32(Console.ReadLine());
                            if (usrGuess == randHard)
                            {
                            Console.WriteLine($"You got it right! Your guess is {usrGuess}");
                            gameStatus = false;
                            break;
                            }
                            else if (usrGuess != randHard)
                            {
                                Console.WriteLine("That was wrong.");
                                guessCount -=1;
                                if (guessCount == 0)
                                {
                                    Console.WriteLine("You've got no more guesses left. Game over!");
                                    gameStatus = false;
                                    break;
                                }
                            }
                        }
                        catch(System.Exception)
                        {
                            Console.WriteLine("Error. Please enter a whole number");
                        }                       
                    }
                }
            }
        }
    }
}