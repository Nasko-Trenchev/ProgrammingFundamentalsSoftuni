using System;

namespace _6._Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string chislo = Convert.ToString(input);
            long factorialSum = 0;

            for (int i = 0; i <= chislo.Length -1; i++)
            {
                char currentnumber = chislo [i];
                int currentDigit = (int)currentnumber - 48;
                int factoriel = 1;
                for (int j = currentDigit; j > 1; j--)
                {
                    factoriel *=j;
                }
                factorialSum += factoriel;
            }

            if (factorialSum == input)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
      
    }
}
