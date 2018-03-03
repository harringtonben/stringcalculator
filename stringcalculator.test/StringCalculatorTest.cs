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

            Assert.AreEqual(0, result);
        }

        [Test]
        public void If_I_have_a_single_number_string_the_method_should_return_that_number()
        {
            var number = "1";
            var calculator = new Calculator();

            var result = calculator.CalculateString(number);

            Assert.AreEqual(1, result);
        }

        [Test]
        public void If_I_have_2_numbers_string_the_method_should_return_that_number()
        {
            var number = "1,2";
            var calculator = new Calculator();

            var result = calculator.CalculateString(number);

            Assert.AreEqual(3, result);
        }
    }
}
