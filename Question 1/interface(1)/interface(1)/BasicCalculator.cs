using System;
using System.Collections.Generic;
using System.Text;

namespace interface_1_
{
    class BasicCalculator : BasicCalculatorInterface
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
    }
}
