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

        }
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Overload operators
       

        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }

    }

 
}
