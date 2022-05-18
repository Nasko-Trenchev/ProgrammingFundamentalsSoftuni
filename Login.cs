using System;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = Console.ReadLine();
            string password = string.Empty;

            for (int reverseIndex = login.Length-1; reverseIndex <= 0; reverseIndex--)
            {
                password += password[reverseIndex];
            }

            for (int i = 0; i < 5; i++)
            {
                string userInput = Console.ReadLine();
                if (userInput == password)
                {
                    Console.WriteLine($"User {login} logged in.");
                    return;
                }
                else 
                {
                    if (i == 3)
                    {
                        Console.WriteLine($"User {login} blocked!");
                        return;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    
                }
                
            }
        }
    }
}
