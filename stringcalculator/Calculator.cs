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
            var numbersList = new List<int>();

            foreach (var num in splitUpNumbers)
            {
                var stringToNumber = int.Parse(num);
                numbersList.Add(stringToNumber);
            }

            return numbersList;
        }
    }
}
