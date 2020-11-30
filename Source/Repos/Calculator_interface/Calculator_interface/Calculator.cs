using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_interface
{
    class Calculator : ICalculator
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Subtraction(int a, int b)
        {
            return a / b;
        }
    }
}
