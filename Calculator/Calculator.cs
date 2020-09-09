using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator{ get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                divisor++;
                Console.WriteLine("Divide by zero: changed divisor to 1");
            }

            return dividend / divisor;
        }

        public double Add(double addend)
        {
            Accumulator = addend + Accumulator;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator = Accumulator - subtractor;
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            Accumulator = multiplier * Accumulator;
            return Accumulator;
        }

        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                divisor++;
                Console.WriteLine("Divide by zero: changed divisor to 1");
            }
            Accumulator = Accumulator / divisor;
            return Accumulator;
        }

        public double Power(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

    }
}
