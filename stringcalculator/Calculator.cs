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

    }
}
