using NUnit.Framework;
using System;
using stringcalculator;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringcalculator.test
{
    [TestFixture]
    public class StringCalculatorTest
    {
        [Test]
        public void If_I_have_an_empty_string_the_method_should_return_0()
        {
            var number = "";
            var calculator = new Calculator();

            var result = calculator.CalculateString(number);

            Assert.AreEqual("0", result);
        }
    }
}
