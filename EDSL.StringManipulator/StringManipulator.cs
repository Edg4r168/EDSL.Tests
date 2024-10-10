namespace EDSL.StringManipulator;

public class StringManipulator
{
    public string ReverseString(string input)
    {
        char[] chars = input.ToCharArray();

        Array.Reverse(chars);

        return new string(chars);
    }

    public string RemoveSpaces(string input)
    {
        return input.Replace(" ", "");
    }
}
