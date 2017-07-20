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

        public double Sum
        {
            get { return _sum; }
            private set { _sum = value; }
        }

        public void Add(double num1, double num2)
        {
            _sum = num1 + num2;
        }
        public void Minus(double num1, double num2)
        {
            _sum = num1 - num2;
        }
        public void Multiply(double num1, double num2)
        {
            _sum = num1 * num2;
        }
        public void Divide(double num1, double num2)
        {
            _sum = num1 / num2;
        }
    }
}