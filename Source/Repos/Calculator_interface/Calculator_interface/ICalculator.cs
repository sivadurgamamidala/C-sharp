using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_interface
{
    interface ICalculator
    {
        int Addition(int a, int b);
        int Subtraction(int a, int b);
        int Multiplication(int a, int b);
        int Division(int a, int b);
    }
}
