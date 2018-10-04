using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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

        public static double Divide(double v1, double v2) 
        {
            return v1 / v2;
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

        public static double Expression(string expr)
        {
            string expection = ", ";
            if (expr.Contains(expection))
            {
                throw new Exception();
            }
            string compressedExpr = Regex.Replace(expr, @"\s+", "");
            List<string> pieces = new List<string>();
            string tempString = "";
            double result = 0;
            for (int i = 0; i < compressedExpr.Length; i++)
            {
                if (compressedExpr[i] == '+' || compressedExpr[i] == '-')
                {
                    pieces.Add(tempString);
                    pieces.Add(compressedExpr[i].ToString());
                    tempString = "";
                }
                else if (i == compressedExpr.Length - 1)
                {
                    tempString += compressedExpr[i].ToString();
                    pieces.Add(tempString);
                }
                else
                {
                    tempString += compressedExpr[i].ToString();
                }
            }

            for (int i = 0; i < pieces.Count; i++)
            {
                if (pieces[i] == "+")
                {
                    double number = Convert.ToDouble(pieces[i + 1]);
                    result = Add(result, number);
                    i++;
                }
                else if (pieces[i] == "-")
                {
                    double number = Convert.ToDouble(pieces[i + 1]);
                    result = Subtract(result, number);
                    i++;
                }
                else
                {
                    double number = Convert.ToDouble(pieces[i]);
                    result += number;
                }
            }
            return result;
        }
    }
}
