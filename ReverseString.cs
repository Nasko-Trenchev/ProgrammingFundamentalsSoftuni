using System;

namespace Additional_4._Reverse_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char symbol = input[i];
                Console.Write(symbol);
            }
        }
    }
}
