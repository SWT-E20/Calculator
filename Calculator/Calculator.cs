using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public double Accumulator{ get; private set; }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator = Math.Pow(x, exp);
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                divisor++;
                Console.WriteLine("Divide by zero: changed divisor to 1");
            }

            Accumulator = dividend/divisor;
            return Accumulator;
        }

        //public double Add(double addend)
        //public double Subtract(double subtractor)
        //public double Multiply(double multiplier)
        //public double Divide(double divisor)
        //public double Power(double exponent)
    }
}
