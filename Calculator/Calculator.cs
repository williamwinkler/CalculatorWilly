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
        public double Accumulator { get; private set; }
        public Calculator()
        {
            Accumulator = 0;
        }
        public double Add(double append)
        {
            Accumulator = Accumulator + append;
            return Accumulator;
        }

        public double Subtract(double subtractor)
        {
            Accumulator = Accumulator - subtractor;
            return Accumulator;
        }

        public double Multiply(double multiplier)
        {
            Accumulator = Accumulator * multiplier;
            return Accumulator;
        }

        public double Pow(double exponent)
        {
            Accumulator = Math.Pow(Accumulator, exponent);
            return Accumulator;
        }

        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            Accumulator = Accumulator/ divisor;
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }

 
}// test
