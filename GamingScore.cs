using System;

namespace Additonal_3._Gaming_score
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string command = string.Empty;
            double totalSpent = 0;

            while (command!= "Game Time")
            {
                command = Console.ReadLine();
                if (command == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${totalSpent:f2}. Remaining: ${currentBalance:f2}");                
                    break;
                }
                else
                {
                    switch (command)
                    {
                        case "OutFall 4":
                            if (currentBalance<39.99)
                            {
                                Console.WriteLine("Too Expensive");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Bought OutFall 4");
                                currentBalance -= 39.99;
                                totalSpent += 39.99;
                            }
                            break;
                        case "CS: OG":
                            if (currentBalance < 15.99)
                            {
                                Console.WriteLine("Too Expensive");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Bought CS: OG");
                                currentBalance -= 15.99;
                                totalSpent += 15.99;
                            }
                            break;
                        case "Zplinter Zell":
                            if (currentBalance < 19.99)
                            {
                                Console.WriteLine("Too Expensive");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Bought Zplinter Zell");
                                currentBalance -= 19.99;
                                totalSpent += 19.99;
                            }
                            break;
                        case "Honored 2":
                            if (currentBalance < 59.99)
                            {
                                Console.WriteLine("Too Expensive");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Bought Honored 2");
                                currentBalance -= 59.99;
                                totalSpent += 59.99;
                            }
                            break;
                        case "RoverWatch":
                            if (currentBalance < 29.99)
                            {
                                Console.WriteLine("Too Expensive");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Bought RoverWatch");
                                currentBalance -= 29.99;
                                totalSpent += 29.99;
                            }
                            break;
                        case "RoverWatch Origins Edition":
                            if (currentBalance < 39.99)
                            {
                                Console.WriteLine("Too Expensive");
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Bought RoverWatch Origins Edition");
                                currentBalance -= 39.99;
                                totalSpent += 39.99;
                            }
                            break;
                        default:
                            Console.WriteLine("Not Found");
                            continue;
                            break;
                    }
                }
                if (currentBalance<=0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
        }
    }
}
