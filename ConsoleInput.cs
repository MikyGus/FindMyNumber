using System;

namespace FindMyNumber
{
    public static class ConsoleInput
    {
        /// <summary>
        /// Prompts the user for an Integer
        /// </summary>
        /// <param name="prompt">Text to prompt the user with.</param>
        /// <param name="errorPrompt">Errortext in case the user types in anything other than a number.</param>
        /// <returns>Returns and Integer from the user</returns>
        public static int GetInt(string prompt = "", string errorPrompt = "You must enter a number!")
        {
            string ReceivedInput;
            int InputToReturn;
            Console.Write(prompt);
            ReceivedInput = Console.ReadLine();

            while (!int.TryParse(ReceivedInput, out InputToReturn))
            {
                if (!string.IsNullOrEmpty(errorPrompt))
                {
                    Console.WriteLine(errorPrompt);
                }
                Console.Write(prompt);
                ReceivedInput = Console.ReadLine();
            }
            return InputToReturn;
        }
    }
}
