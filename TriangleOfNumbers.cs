using System;

namespace _8._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int stars = int.Parse(Console.ReadLine());

            for (int i = 1; i <= stars; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine("");
            }

        }
    }
}
