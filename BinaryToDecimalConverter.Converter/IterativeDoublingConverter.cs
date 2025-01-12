namespace BinaryToDecimalConverter.Converter;

/// <summary>
/// Iterative implementation of a binary-to-decimal converter using the doubling method.
/// </summary>
public class IterativeDoublingConverter : IConverter
{
    public long Convert(string input)
    {
        var res = 0L;
        foreach (var digit in input)
        {
            res = res * 2 + int.Parse(digit.ToString());
        }

        return res;
    }
}