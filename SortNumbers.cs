using System;

namespace Additional_1._Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());

            double firsNumber = 0;
            double secondNumber = 0;
            double lastNumber = 0;

            double firstNumber = 0;
            double secondNUmber = 0;
            double thirdNumber = 0;

            if (number1 > number2 && number1 > number3)
            {
                firstNumber = number1;
                if (number2 > number3)
                {
                    secondNUmber = number2;
                    thirdNumber = number3;
                }
                else
                {
                    secondNUmber = number3;
                    thirdNumber = number2;
                }
            }
            else if (number2 > number1 && number2 > number3)
            {
                firstNumber = number2;
                if (number1 > number3)
                {
                    secondNUmber = number1;
                    thirdNumber = number3;
                }
                else
                {
                    secondNUmber = number3;
                    thirdNumber = number1;
                }
            }
            else
            {
                firstNumber = number3;
                if (number1 > number2)
                {
                    secondNUmber = number1;
                    thirdNumber = number2;
                }
                else
                {
                    secondNUmber = number2;
                    thirdNumber = number1;
                }
            }
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNUmber);
            Console.WriteLine(thirdNumber);


        }
    }
}
