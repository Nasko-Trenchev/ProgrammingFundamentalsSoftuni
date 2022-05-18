using System;

namespace _7._Vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialCoin = string.Empty;

            bool result;
            double a;
            double sumOfCoins = 0;

            while (initialCoin != "Start")
            {
                initialCoin = Console.ReadLine();
                result = double.TryParse(initialCoin, out a);
                if (result)
                {
                    double toDouble = Convert.ToDouble(initialCoin);
                    if (toDouble == 0.1 || toDouble == 0.2 || toDouble == 0.5 || toDouble == 1 || toDouble == 2)
                    {
                        sumOfCoins += toDouble;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {toDouble}");
                    }
                }
                else
                {
                    break;
                }
            }
            string products = string.Empty;
            double nuts = 2;
            double water = 0.7;
            double crisp = 1.5;
            double soda = 0.8;
            double coke = 1;
            while (products != "End")
            {
                products = Console.ReadLine();

                if (products == "End")
                {
                    Console.WriteLine($"Change: {sumOfCoins:f2}");
                    break;
                }

                else if ((products != "Nuts" && products != "Water" && products != "Crisps" && products != "Soda" && products != "Coke"))
                {
                    Console.WriteLine("Invalid product");
                }              
                else
                {
                    switch (products)
                    {
                        case "Nuts":
                            if (sumOfCoins>=nuts)
                            {                        
                                Console.WriteLine($"Purchased nuts");
                                sumOfCoins -= 2;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Water":
                            if (sumOfCoins >= water)
                            {                                
                                Console.WriteLine($"Purchased water");
                                sumOfCoins -= 0.7;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Crisps":
                            if (sumOfCoins >= crisp)
                            {                             
                                Console.WriteLine($"Purchased crisps");
                                sumOfCoins -= 1.5;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Soda":
                            if (sumOfCoins >= soda)
                            {                           
                                Console.WriteLine($"Purchased soda");
                                sumOfCoins -= 0.8;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        case "Coke":
                            if (sumOfCoins >= coke)
                            {                             
                                Console.WriteLine($"Purchased coke");
                                sumOfCoins -= 1;
                            }
                            else
                            {
                                Console.WriteLine("Sorry, not enough money");
                            }
                            break;
                        default:
                            break;
                    }
                }
               
            }

        }
    }
}
