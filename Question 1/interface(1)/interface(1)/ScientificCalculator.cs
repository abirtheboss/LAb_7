using System;
using System.Collections.Generic;
using System.Text;

namespace interface_1_
{
    class ScientificCalculator : BasicCalculatorInterface, ScientificCalculatrorInterface
    {
        public int division(int x, int y)
        {
            return x / y;
        }

        public int multiplication(int x, int y)
        {
            return x * y;
        }

        public int sub(int x, int y)
        {
            return x - y;
        }

        public int sum(int x, int y)
        {
            return x + y;
        }

        public double root(int x)
        {
            return Math.Sqrt(x);
        }

        public int square(int x)
        {
            return x * x;
        }

        public int XtoY(int x, int y)
        {
            return y;
        }
    }
}
