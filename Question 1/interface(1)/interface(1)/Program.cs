using System;

namespace interface_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator basicCalculator = new BasicCalculator();

            Console.WriteLine(basicCalculator.sum(5, 5));
            Console.WriteLine(basicCalculator.sub(10, 10));
            Console.WriteLine(basicCalculator.multiplication(5, 5));
            Console.WriteLine(basicCalculator.division(10, 10));

            ScientificCalculator scientificCalculator = new ScientificCalculator();

            Console.WriteLine(scientificCalculator.root(64));
            Console.WriteLine(scientificCalculator.square(4));
            Console.WriteLine(scientificCalculator.sub(10, 15));
            Console.WriteLine(scientificCalculator.multiplication(5, 5));


        }
    }
}
