using System;

namespace Additional_5._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int letters = int.Parse(Console.ReadLine());
            int offSetNumber = 0;
            int letterIndex = 0;
            string final = string.Empty;

            for (int i = 0; i < letters; i++)
            {
                int number = int.Parse(Console.ReadLine());
                string numberToString = number.ToString();
                int numberLenght = numberToString.Length - 1;
                int mainDigit = number % 10;

                if (mainDigit == 8 || mainDigit == 9)
                {
                    offSetNumber = (mainDigit - 2) * 3 + 1;
                }
                else
                {
                    offSetNumber = (mainDigit - 2) * 3;
                }
                
                letterIndex = offSetNumber + (numberLenght);
                int symbol = letterIndex + 97;
                if (mainDigit == 0)
                {
                    final += (char)32;
                }
                else
                {
                    final += (char)symbol;
                }
                            
            }
            Console.WriteLine(final);
        }
    }
}
