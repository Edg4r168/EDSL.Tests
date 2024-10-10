using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Calculadora.Tests;

[TestClass()]
public class CalculatorTests
{
    private readonly Calculator _calculator = new Calculator();

    [TestMethod()]
    public void AddTest()
    {
        double result = _calculator.Add(5, 3);

        Assert.AreEqual(8, result);
    }

    [TestMethod()]
    public void SubtractTest()
    {
        double result = _calculator.Subtract(5, 3);

        Assert.AreEqual(2, result);
    }

    [TestMethod()]
    public void MultiplyTest()
    {
        double result = _calculator.Multiply(5, 3);

        Assert.AreEqual(15, result);
    }

    [TestMethod()]
    public void DivideTest()
    {
        double result = _calculator.Subtract(6, 2);

        Assert.AreEqual(3, result);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void DivideByZeroTest()
    {
        double result = _calculator.Divide(5, 0);
    }
}