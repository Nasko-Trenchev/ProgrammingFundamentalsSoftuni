using System;

namespace _3.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double countOfPeople = double.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double price = 0;
            double totalPrice = 0;

            switch (groupType)
            {
                case "Students":
                    switch (weekDay)
                    {
                        case "Friday": price = 8.45;
                            break;
                        case "Saturday": price = 9.8;
                            break;
                        case "Sunday": price = 10.46;
                            break;
                        default:
                            break;
                    }
                    if (countOfPeople >= 30)
                    {
                        totalPrice = (price * countOfPeople)*0.85;
                    }
                    else
                    {
                        totalPrice = (price * countOfPeople);
                    }
                    break;
                case "Business":
                    switch (weekDay)
                    {
                        case "Friday":
                            price = 10.9;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16;
                            break;
                        default:
                            break;
                    }
                    if (countOfPeople >=100)
                    {
                        countOfPeople = countOfPeople - 10;
                    }                 
                        totalPrice = price * countOfPeople;                    
                    break;
                case "Regular":
                    switch (weekDay)
                    {
                        case "Friday":
                            price = 15;
                            break;
                        case "Saturday":
                            price = 20;
                            break;
                        case "Sunday":
                            price = 22.5;
                            break;
                        default:
                            break;
                    }
                    if (countOfPeople>=10 && countOfPeople <=20)
                    {
                        totalPrice = (price * countOfPeople)*0.95;
                    }
                    else
                    {
                        totalPrice = (price * countOfPeople);
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
