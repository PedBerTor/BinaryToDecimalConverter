namespace BinaryToDecimalConverter.Converter;

/// <summary>
/// Functional implementation of a binary-to-decimal converter using positional notation.
/// </summary>
public class FunctionalPositionalNotationConverter : IConverter
{
    public long Convert(string input)
    {
        var res = input.Take(input.Length - 1)
            .Select((digit, index) => digit == '1' ? (long)Math.Pow(2, input.Length - 1 - index) : 0L)
            .Sum();
        return res + (input.EndsWith('1') ? 1L : 0L);
    }
}