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

        [Test]
        public void If_I_have_6_numbers_string_the_method_should_return_that_number()
        {
            var number = "1,2,3,4,5,6";
            var calculator = new Calculator();

            var result = calculator.CalculateString(number);

            Assert.AreEqual(21, result);
        }

        [Test]
        public void If_I_have_enter_a_number_greater_than_1000_then_the_calculator_should_ignore_it()
        {
            var number = "1,1005";
            var calculator = new Calculator();

            var result = calculator.CalculateString(number);

            Assert.AreEqual(1, result);
        }
    }
}
