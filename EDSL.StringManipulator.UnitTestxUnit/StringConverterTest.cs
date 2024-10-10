namespace EDSL.StringManipulator.UnitTestxUnit;

public class StringConverterTest
{
    private readonly StringManipulator _stringManipulator = new StringManipulator();

    [Fact]
    public void ReverseString_InputIsHello_ShouldReturnOlleh()
    {
        string input = "Hello";
        string expected = "olleH";

        string result = _stringManipulator.ReverseString(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void ReverseString_InputIsEmpty_ShouldReturnEmpty()
    {
        string input = "";
        string expected = "";

        string result = _stringManipulator.ReverseString(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void RemoveSpaces_InputWithSpaces_ShouldReturnWithoutSpaces()
    {
        string input = "Hello World";
        string expected = "HelloWorld";

        string result = _stringManipulator.RemoveSpaces(input);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void RemoveSpaces_InputWithoutSpaces_ShouldReturnSameString()
    {
        string input = "NoSpaces";
        string expected = "NoSpaces";

        string result = _stringManipulator.RemoveSpaces(input);

        Assert.Equal(expected, result);
    }
}
