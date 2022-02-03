using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public Calculator()
        {
            Accumulator = 0;
        }
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a- b;
            return Accumulator;
        }

        // Overload operators
       

        public double Multiply(double a, double b)
        {
            Accumulator = a *b;
            return Accumulator;
        }
        public double Pow(double a, double b)
        {
            Accumulator = Math.Pow(a, b);
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {
            Accumulator = dividend / divisor;
            return Accumulator;
        }

        public double Accumulator { get; private set; }


    }

 
}
