namespace EDSL.Temperatura.Tests;

[TestClass()]
public class TemperaturaConverterTests
{
    private readonly TemperaturaConverter _converter;

    [TestMethod()]
    public void CelsiusToFahrenheitTest()
    {
        double result = _converter.CelsiusToFahrenheit(25);

        Assert.AreEqual(77, result);
    }

    [TestMethod()]
    public void FahrenheitToCelsiusTest()
    {
        double result = _converter.CelsiusToFahrenheit(77);

        Assert.AreEqual(25, result);
    }
}