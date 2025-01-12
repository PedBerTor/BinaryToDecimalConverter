namespace BinaryToDecimalConverter.Converter;

/// <summary>
/// Interface representing a binary-to-decimal converter.
/// </summary>
public interface IConverter
{
    /// <summary>
    /// Converts a binary string representation to its decimal equivalent.
    /// </summary>
    /// <param name="input">
    /// A string containing the binary representation (e.g., "1010").
    /// </param>
    /// <returns>
    /// The decimal equivalent of the binary input.
    /// </returns>
    public long Convert(string input);
}