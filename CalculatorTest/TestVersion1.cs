using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorTest
{
    [TestClass]
    public class TestVersion1
    {
        double delta = 0.0000000000001; // Handles double accuracy

        [TestMethod]
        public void TestAdd()
        {
            Assert.AreEqual(0, Calculator.Add(0, 0));
            Assert.AreEqual(11.75, Calculator.Add(2.5, 9.25));
            Assert.AreEqual(104.75, Calculator.Add(98.0, 6.75));
            Assert.AreEqual(208.2, Calculator.Add(148.3, 59.9), delta);
        }
        [TestMethod]
        public void TestSubtract()
        {
            Assert.AreEqual(5.5, Calculator.Subtract(10.3, 4.8), delta);
            Assert.AreEqual(10.0, Calculator.Subtract(20.1, 10.1), delta);
        }
        [TestMethod]
        public void TestMultiply()
        {
            Assert.AreEqual(49.44, Calculator.Multiply(10.3, 4.8), delta);
            Assert.AreEqual(203.01, Calculator.Multiply(20.1, 10.1), delta);
        }
        [TestMethod]
        public void TestDivide()
        {
            Assert.AreEqual(2.5, Calculator.Divide(11.5, 4.6));
            Assert.AreEqual(2.0, Calculator.Divide(20.2, 10.1));
        }
        [TestMethod]
        public void TestSum()
        {
            double[] numbers = new double[2];
            Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers[0] = 7.9;
            Assert.AreEqual(7.9, Calculator.Sum(numbers));

            numbers[1] = 11.1;
            Assert.AreEqual(19, Calculator.Sum(numbers));

        }
    }
}
