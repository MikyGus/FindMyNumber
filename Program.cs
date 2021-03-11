using System;

namespace FindMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MinRange = 1;
            const int MaxRange = 100;
            const int TotalTries = 5;
            string PromptForInput = $"Guess a number ({MinRange}-{MaxRange}): ";
            var rnd = new Random();
            int SecretNumber = rnd.Next(MinRange,MaxRange+1);
            bool foundSecret = false;

            for (int i = 0; i < TotalTries; i++)
            {
                int UserGuessed = ConsoleInput.GetInt(PromptForInput);

                if (UserGuessed == SecretNumber)
                {
                    Console.WriteLine($"You guessed correctly with only {i+1} tries.");
                    foundSecret = true;
                    break;
                }
                else if (UserGuessed > SecretNumber)
                {
                    Console.Write($"My secret number is less than {UserGuessed}. Tries left: {TotalTries - i - 1}. ");
                }
                else
                {
                    Console.Write($"My secret number is greater than {UserGuessed}. Tries left: {TotalTries - i - 1}. ");
                }

            }

            if (foundSecret)
            {
                string[] Message = { "CONTRATULATIONS! YOU FOUND MY SECRET NUMBER!" };
                ConsolePrint.PrintMessages(Message);
            }
            else
            {
                string[] Message = {
                    "SORRY, YOU DIDN'T FIND MY SECRET NUMBER!",
                    $"MY SECRET WAS: {SecretNumber}"
                };
                ConsolePrint.PrintMessages(Message);
            }

        }
    }
}
