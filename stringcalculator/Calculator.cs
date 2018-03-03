using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringcalculator
{
    public class Calculator
    {
        public int CalculateString(string number)
        {
            if (number == "")
            {
                return 0;
            }
            var myNumbers = parseNumbers(number);
            var returnNumber = 0;
            foreach (var num in myNumbers)
            {
                returnNumber += num;
            }
         
            return returnNumber;
        }

        List<int> parseNumbers(string number)
        {
            var splitUpNumbers = number.Split(',');
            var splitNumbers = NumberMyString(splitUpNumbers);
            CheckForNegatives(splitNumbers);
            var numbersList = new List<int>();
            
            foreach (var num in splitNumbers)
            {   
                if (num < 1000)
                    numbersList.Add(num);
            }

            return numbersList;
        }

        List<int> NumberMyString(string[] stringOfNumbers)
        {
            var numberReturn = new List<int>();
            foreach (var num in stringOfNumbers)
            {
                var stringToNumber = int.Parse(num);
                numberReturn.Add(stringToNumber);
            }
            return numberReturn;
        }

        private void CheckForNegatives(List<int> numbers)
        {
            var negativeNumbers = new List<int>();

            foreach (var num in numbers)
            {
                if (num < 0)
                    negativeNumbers.Add(num);                    
            }

            if (negativeNumbers.Count > 0)
            {
                var negativesToString = string.Join(",", negativeNumbers.Select(x=> x.ToString()));
                throw new Exception($"You are receiving this message because you entered the negative numbers ({negativesToString}), which the application does not support.");
            }
        }

    }
}
