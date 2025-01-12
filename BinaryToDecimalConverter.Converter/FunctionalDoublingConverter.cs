namespace BinaryToDecimalConverter.Converter;

/// <summary>
/// Functional implementation of a binary-to-decimal converter using the doubling method.
/// </summary>
public class FunctionalDoublingConverter : IConverter
{
    public long Convert(string input)
    {
        return input.Aggregate(0L, (agg, digit) => agg * 2 + int.Parse(digit.ToString()));
    }
}