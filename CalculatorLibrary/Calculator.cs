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
            double result = 0.0;

            foreach (var item in numbers)
            {
                result += item;
            }

            return result;
        }

        public static double Minimum(double[] numbers)
        {
            double result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (result > numbers[i])
                {
                    result = numbers[i];
                }
            }
            return result;
        }

        public static double Maximum(double[] numbers)
        {
            double result = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (result < numbers[i])
                {
                    result = numbers[i];
                }
            }
            return result;
        }

        public static double Average(double[] numbers)
        {
            return Sum(numbers) / numbers.Length;
        }
    }
}
