using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class CalculatorClass
    {
        public int Addition(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public int Subtract(int left, int right)
        {
            return left - right;
        }

        public int Multiply(int a, int b)
        {

            return a*b;
        }

        public double Divide(double a, double b)
        {

            return a/b;
        }

        public double Exponents(double a, double b)
        {

            return Math.Pow(a,b);
        }

        public int Factorial(int a)
        {

            if (a == 0)
            {
                return 1;
            }
            return a * Factorial(a - 1);


        }
    }
}
