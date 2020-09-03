using System;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorUnitTest
    {
        private Calculator uut;
        private double _result;

        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
            _result = 0;
        }

        [TestCase(5,13,18)]
        [TestCase(-5,5,0)]
        [TestCase(5.4, 13.8,19.2)]
        [TestCase(7, 0, 7)]
        public void Add_TwoNumbers_ReturnCorrectResult(double firstNumber, double secondNumber, double result)
        {
            _result = uut.Add(firstNumber, secondNumber);

            Assert.That(_result, Is.EqualTo(result).Within(0.005));
        }

        [TestCase(5, 13, -8)]
        [TestCase(-5, 5, -10)]
        [TestCase(5.4, 13.8, -8.4)]
        [TestCase(7, 0, 7)]
        public void Subtract_TwoNumbers_ReturnCorrectResult(double firstNumber, double secondNumber, double result)
        {
            _result = uut.Subtract(firstNumber, secondNumber);

            Assert.That(_result, Is.EqualTo(result).Within(0.005));
        }

        [TestCase(5, 13, 65)]
        [TestCase(-5, 5, -25)]
        [TestCase(5.4, 13.8, 74.52)]
        [TestCase(7, 0, 0)]
        public void Multiply_TwoNumbers_ReturnCorrectResult(double firstNumber, double secondNumber, double result)
        {
            _result = uut.Multiply(firstNumber, secondNumber);

            Assert.That(_result, Is.EqualTo(result).Within(0.005));
        }

        [TestCase(5, 3, 125)]
        [TestCase(-5, 5, -3125)]
        [TestCase(5.4, 3.8, 606.8709)]
        [TestCase(7, 0, 1)]
        [TestCase(0, 7, 0)]
        public void Power_TwoNumbers_ReturnCorrectResult(double firstNumber, double secondNumber, double result)
        {
            _result = uut.Power(firstNumber, secondNumber);

            Assert.That(_result, Is.EqualTo(result).Within(0.005));
        }
    }
}
