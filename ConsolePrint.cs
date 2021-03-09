using System;

namespace FindMyNumber
{
    static class ConsolePrint
    {
        /// <summary>
        /// Prints messages to the Console with a border of '#'
        /// </summary>
        /// <param name="messages">A list of messages to print. Each string in the Array is printed on a separate line.</param>
        public static void PrintMessages(string[] messages)
        {
            int MessageMaxLength = GetMaxLengthOfStrings(messages);
            if (MessageMaxLength == 0) return;

            string BorderChars = "##";
            int MaxLengthNeeded = ((BorderChars.Length + 1) * 2) + MessageMaxLength;

            Console.WriteLine("\n\n" + new string('#', MaxLengthNeeded));
            foreach (string msg in messages)
            {
                int spaceTaken = msg.Length + (BorderChars.Length * 2);
                Console.WriteLine(BorderChars + Padding(MaxLengthNeeded, spaceTaken) + msg + Padding(MaxLengthNeeded, spaceTaken, false) + BorderChars);
            }
            Console.WriteLine(new string('#', MaxLengthNeeded));
        }

        private static string Padding(int maxRowLength, int spaceTaken, bool isLeftSide = true)
        {
            double PaddingSpace = (maxRowLength - spaceTaken) / 2.0;
            if (isLeftSide)
            {
                PaddingSpace = Math.Floor(PaddingSpace);
            }
            else
            {
                PaddingSpace = Math.Ceiling(PaddingSpace);
            }
            return new string(' ', (int)PaddingSpace);
        }
        private static int GetMaxLengthOfStrings(string[] messages)
        {
            int LengthToReturn = 0;
            foreach (string msg in messages)
            {
                LengthToReturn = Math.Max(msg.Length, LengthToReturn);
            }
            return LengthToReturn;

        }
    }
}
