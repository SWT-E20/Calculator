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

        [TestCase(6,13,19)]
        [TestCase(-5,5,0)]
        [TestCase(5.4, 13.8,19.2)]
        [TestCase(7, 0, 7)]
        [TestCase(3, 1.7, 4.7)]
        public void Add_TwoNumbers_ReturnCorrectResult(double firstNumber, double secondNumber, double result)
        {
            _result = uut.Add(firstNumber, secondNumber);

            Assert.That(_result, Is.EqualTo(result).Within(0.005));
            
            // alternate way:
            Assert.AreEqual(_result, result, 0.005);
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
        [TestCase(8, 0, 0)]
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

        [TestCase(10, 5, 2)]
        [TestCase(-10, 5, -2)]
        [TestCase(-10, -2, 5)]
        [TestCase(1, 0, 1)]
        public void Divide_TwoNumbers_ReturnCorrectResult(double firstNumber, double secondNumber, double result)
        {
            _result = uut.Divide(firstNumber, secondNumber);

            Assert.That(_result, Is.EqualTo(result).Within(0.005));
        }

        [TestCase(10, 5, 10, 2, 2, 625)]
        [TestCase(10, 5, 100, 100, 5, 3125)]
        [TestCase(2.5, 3.3, 1.6, 8, -2, 39.0625)]
        [TestCase(2, 1, 0, 8, 2, 0)]
        [TestCase(3, -3, 2, 4, 2, 9)]
        public void Accumulate_MultipleOperations_ReturnCorrectResult(double addNum, double subNum, double mulNum, double divNum, double powNum, double result)
        {
            uut.Add(addNum);
            uut.Subtract(subNum);
            uut.Multiply(mulNum);
            uut.Divide(divNum);
            _result = uut.Power(powNum);

            Assert.That(_result, Is.EqualTo(result).Within(0.001));
        }

        [TestCase()]
        public void Clear_ClearsAccumulator_AccumulatorIsCleared()
        {
            uut.Add(5);
            _result = uut.Add(5);
            Assert.That(_result, Is.EqualTo(10));

            uut.Clear();

            _result = uut.Add(5);

            Assert.That(_result, Is.EqualTo(5));
        }
    }
}
