﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            var calc = new Calculator();

            result = calc.Add(3, 5);
            Console.WriteLine(result);

            result = calc.Add(-3, 5);
            Console.WriteLine(result);

            result = calc.Subtract(3, 5);
            Console.WriteLine(result);

            result = calc.Multiply(3, 5);
            Console.WriteLine(result);

            result = calc.Multiply(-2, -2);
            Console.WriteLine(result);

            result = calc.Power(3, 5);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
