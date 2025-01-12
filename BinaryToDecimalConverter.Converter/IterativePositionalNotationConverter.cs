namespace BinaryToDecimalConverter.Converter;

/// <summary>
/// Iterative implementation of a binary-to-decimal converter using positional notation.
/// </summary>
public class IterativePositionalNotationConverter : IConverter
{
    public long Convert(string input)
    {
        var res = input.EndsWith('1') ? 1L : 0L;

        for (var i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == '1')
            {
                res += (long)Math.Pow(2, input.Length - 1 - i);
            }
        }

        return res;
    }
}