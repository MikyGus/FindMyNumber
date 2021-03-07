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
            int UserGuessed;

            for (int i = 0; i < TotalTries; i++)
            {
                UserGuessed = GetIntFromUser(PromptForInput);

                if (UserGuessed == SecretNumber)
                {
                    Console.WriteLine($"You guessed correctly with only {i+1} tries.");
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

        }

        static int GetIntFromUser(string prompt = "")
        {
            string ReceivedInput;
            int InputToReturn;
            Console.Write(prompt);
            ReceivedInput = Console.ReadLine();

            while (!int.TryParse(ReceivedInput, out InputToReturn))
            {
                Console.WriteLine("You must enter a number!");
                Console.Write(prompt);
                ReceivedInput = Console.ReadLine();
            }
            return InputToReturn;
        }
    }
}
