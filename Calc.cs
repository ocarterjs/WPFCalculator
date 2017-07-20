using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.cs
{
    class Calc
    {
        private double _sum;

        // class constructor intializing sum variable.
        public double Sum
        {
            get { return _sum; }
            private set { _sum = value; }
        }

        // Function to add two values together.
        public void Add(double num1, double num2)
        {
            _sum = num1 + num2;
        }
        // Function to subtract two values from each other.
        public void Minus(double num1, double num2)
        {
            _sum = num1 - num2;
        }
        // Function to multiply two values together.
        public void Multiply(double num1, double num2)
        {
            _sum = num1 * num2;
        }
        // Function to divide two values from each other.
        public void Divide(double num1, double num2)
        {
            _sum = num1 / num2;
        }
    }
}
