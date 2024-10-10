namespace Test.Calculadora.UnitTest.AppxUnit;

public class CalculatorTest
{
    private readonly Calculator _calculator = new Calculator();

    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        double num1 = 5.0;
        double num2 = 3.0;

        double result = _calculator.Add(num1, num2);

        Assert.Equal(8.0, result);
    }

    [Fact]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        double num1 = 8.0;
        double num2 = 3.0;

        double result = _calculator.Subtract(num1, num2);

        Assert.Equal(5.0, result);
    }

    [Fact]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        double num1 = 4.0;
        double num2 = 2.0;

        double result = _calculator.Multiply(num1, num2);

        Assert.Equal(8.0, result);
    }

    [Fact]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        double num1 = 10.0;
        double num2 = 2.0;

        double result = _calculator.Divide(num1, num2);

        Assert.Equal(5.0, result);
    }

    [Fact]
    public void Divide_ByZero_ShouldThrowException()
    {
        double num1 = 5.0;
        double num2 = 0.0;

        Assert.Throws<ArgumentException>(() => _calculator.Divide(num1, num2));
    }
}
