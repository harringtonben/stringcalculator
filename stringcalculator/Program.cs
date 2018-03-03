using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringcalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var run = true;
            while (run)
            {
                Console.WriteLine("Enter as many numbers as you would like seperated by commas, and I will return their sum. Please Do not use numbers greater than 1000, or negative numbers. Type quit to exit.");
                var userInput = Console.ReadLine();
                if (userInput == "quit")
                {
                    run = false;
                    break;
                }
                var calculator = new Calculator();
                var mySum = calculator.CalculateString(userInput);
                Console.WriteLine($"The sum of {userInput} is {mySum}");
            }
        }
    }
}
