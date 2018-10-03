using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double Add(double v1, double v2)
        {
            return v1 + v2;
        }

        public static double Subtract(double v1, double v2)
        {
            return v1 - v2;
        }

        public static double Multiply(double v1, double v2)
        {
            return v1 * v2;
        }

        public static double Divide(double v1, double v2) //Mathias
        {
            throw new NotImplementedException();
        }

        public static double Sum(double[] numbers)
        {
            return numbers.Sum();
        }

        public static double Minimum(double[] numbers)
        {
            return numbers.Min();
        }

        public static double Maximum(double[] numbers)
        {
            return numbers.Max();
        }

        public static double Average(double[] numbers)
        {
            return numbers.Average();
        }
    }
}
