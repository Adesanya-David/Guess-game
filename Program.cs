using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class program
{
    public static void Main()
    {
        bool endprogram = false;
        int choice = 0;

        while (!endprogram)
        {
            Console.WriteLine("********HOW GOOD ARE YOU AT GUESSING?**************\n");
            Console.WriteLine("1. EASY\n");
            Console.WriteLine("2. MEDIUM\n");
            Console.WriteLine("3. HARD\n");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("*********************************************\n\n");
            Console.WriteLine("Enter your choice: \n");
            
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    bool Easy = true;
                    int maxTrys = 6;
                    Random random = new Random();

                    while (Easy)
                    {
                        int rand = random.Next(1, 11);

                        Console.WriteLine("I am thinking of a number between 1 and 10 Can you guess? ");
                        Console.WriteLine(string.Format("\nYou have {0} attempts to win the game.", maxTrys));
                        int trys = 0;
                        bool solved = false;
                        while (!solved && trys < maxTrys)
                        {
                            trys++;
                            int guess;
                            bool numericGuess;
                            do
                            {
                                numericGuess = int.TryParse(Console.ReadLine(), out guess);
                                if (!numericGuess)
                                {
                                    Console.WriteLine("Please enter a number");
                                }
                            } while (!numericGuess);

                            if (guess > rand)
                            {
                                Console.WriteLine(string.Format("That was wrong! My number is lower than {0}\n guess again >>", guess));
                            }
                            else if (guess < rand)
                            {
                                Console.WriteLine(string.Format("That was wrong! My number is higher than {0}\n guess again >>", guess));
                            }
                            else if (guess == rand)
                            {
                                solved = true;
                                Console.WriteLine(string.Format("You got it right! My number is {0} and you have {1} tries left ", rand, trys));
                            }
                        }
                        if (!solved)
                        {
                            Console.Clear();
                            Console.WriteLine(string.Format("You've used {0} trys. Game Over! \n", maxTrys));
                        }

                        Console.WriteLine("Press R + Enter to play this level again or Q to start a New game");
                        string rerun = Console.ReadLine().ToUpper();

                        if (!rerun.Equals("R"))
                        {
                            Easy = false;
                        }

                    }

                    break;
                case 2:
                    
                    bool Medium = true;
                    int maxTries = 4;
                    Random randm = new Random();

                    while (Medium)
                    {
                        int rnd = randm.Next(1, 21);

                        Console.WriteLine("I am thinking of a number between 1 and 20 Can you guess? ");
                        Console.WriteLine(string.Format("\nYou have {0} attempts to win the game.", maxTries));
                        int trys = 0;
                        bool solved = false;
                        while (!solved && trys < maxTries)
                        {
                            trys++;
                            int guess;
                            bool numericGuess;
                            do
                            {
                                numericGuess = int.TryParse(Console.ReadLine(), out guess);
                                if (!numericGuess)
                                {
                                    Console.WriteLine("Please enter a number");
                                }
                            } while (!numericGuess);

                            if (guess > rnd)
                            {
                                Console.WriteLine(string.Format("That was wrong! My number is lower than {0}\n  guess again >>", guess));
                            }
                            else if (guess < rnd)
                            {
                                Console.WriteLine(string.Format("That was wrong! My number is higher than {0}\n You have {1} tries. guess again >>", guess, trys));
                            }
                            else if (guess == rnd)
                            {
                                solved = true;
                                Console.WriteLine(string.Format("You got it right! My number is {0} and you have {1} tries left ", rnd, trys));
                            }
                        }
                        if (!solved)
                        {
                            Console.Clear();
                            Console.WriteLine(string.Format("You've used {0} trys. Game Over! \n", maxTries));
                        }

                        Console.WriteLine("Press R + Enter to play this level again or Q to start a New game");
                        string rerun = Console.ReadLine().ToUpper();

                        if (!rerun.Equals("R"))
                        {
                            Medium = false;
                        }

                    }
                    break;
                case 3:
                    bool Hard = true;
                    int maxTrials = 3;
                    Random rndom = new Random();

                    while (Hard)
                    {
                        int rnd = rndom.Next(1, 51);

                        Console.WriteLine("I am thinking of a number between 1 and 50 Can you guess? ");
                        Console.WriteLine(string.Format("\nYou have {0} attempts to win the game.", maxTrials));
                        
                        int trys = 0;
                        bool solved = false;
                        while (!solved && trys < maxTrials)
                        {
                            trys++;
                            int guess;
                            bool numericGuess;
                            do
                            {
                                numericGuess = int.TryParse(Console.ReadLine(), out guess);
                                if (!numericGuess)
                                {
                                    Console.WriteLine("\n Please enter a number");
                                }
                            } while (!numericGuess);

                            if (guess > rnd)
                            {
                                Console.WriteLine(string.Format("My number is lower than {0}\n guess again >>", guess, maxTrials));
                            }
                            else if (guess < rnd)
                            {
                                Console.WriteLine(string.Format("My number is higher than {0}\n guess again >>", guess));
                            }
                            else if (guess == rnd)
                            {
                                solved = true;
                                Console.WriteLine(string.Format("You got it right! My number is {0} and you used {1} trys", rnd, trys));
                            }
                        }
                        if (!solved)
                        {
                            Console.Clear();
                            Console.WriteLine(string.Format("You have used {0} trys. Game Over! \n", maxTrials));
                        }

                        Console.WriteLine("Press R + Enter to play this level again or Q to start a New game");
                        string rerun = Console.ReadLine().ToUpper();

                        if (!rerun.Equals("R"))
                        {
                            Hard = false;
                        }
                        
                    }
                    break;
                case 4:
                    endprogram = true;
                    break;
            }

            Console.WriteLine("\n Do you want to Start a New Game? Yes/No ");
            string AnT = Console.ReadLine();

            if (AnT == "Yes")
            {
                endprogram = false;
            }
            else
            {
                endprogram = true;
            }

        }

    }
}