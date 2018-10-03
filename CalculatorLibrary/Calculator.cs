using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double Add(double v1, double v2) //Kaare
        {
            return v1 + v2;
        }

        public static double Subtract(double v1, double v2) //Anders
        {
            return v1 - v2;
        }

        public static double Multiply(double v1, double v2) //Brian
        {
            return v1 * v2;
        }

        public static double Divide(double v1, double v2) //Mathias
        {
            throw new NotImplementedException();
        }

        public static double Sum(double[] numbers) //Whoever
        {
            return numbers.Sum();
        }
    }
}
