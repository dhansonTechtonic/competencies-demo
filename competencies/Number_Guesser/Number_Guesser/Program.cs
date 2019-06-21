using System;

namespace Number_Guesser
{
    class MainClass
    {
        public static void play_game()
        {
            Console.Write("Give me a max number please   ");
            String maxString = Console.ReadLine();
            int max = 0;
            if (!Int32.TryParse(maxString, out max))
            {
                max = -1;
            }

            if (max == -1)
            {
                Console.Write("Please enter a number   ");
            }
            else
            {
                int RandomNumber(int min, int maxNum)
                {
                    Random random = new Random();
                    return random.Next(min, maxNum);
                }

                int randomNum = RandomNumber(1, max);

                Console.Write("Please give me a number between 1 and " + max + "   ");
                int guess = 0;
                do
                {
                    if (!Int32.TryParse(Console.ReadLine(), out guess))
                    {
                        guess = -1;
                    }
                    if (guess == -1)
                    {
                        Console.Write("Enter a number please!   ");
                    }
                    else
                    {
                        if (guess < randomNum)
                        {
                            Console.Write("Enter a higher number   ");
                        }
                        else if (guess > randomNum)
                        {
                            Console.Write("Enter a lower number   ");
                        }
                    }

                } while (guess != randomNum);
                Console.Write("Correct! Would you like to play again? Yes or No   ");
                String playAgain = Console.ReadLine();
                if (playAgain == "Yes" || playAgain == "yes")
                {
                    play_game();
                }else if (playAgain == "No" || playAgain == "no")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.Write("Erg");
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.Write("Would you like to play a game? Yes or No   ");
            String play = Console.ReadLine();
            if (play == "Yes" || play == "yes")
            {
                play_game();
            }else if(play == "No" || play == "no")
            {
                Console.Write("Um....okay   ");
            }
            else
            {
                Console.Write("Please enter Yes or No   ");
            }
        }
    }
}
