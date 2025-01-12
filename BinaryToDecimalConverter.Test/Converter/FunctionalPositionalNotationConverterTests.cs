using BinaryToDecimalConverter.Converter;

namespace BinaryToDecimalConverter.Test.Converter;

/// <summary>
/// Tests for <see cref="FunctionalPositionalNotationConverter"/>.
/// </summary>
public class FunctionalPositionalNotationConverterTests
{
    private FunctionalPositionalNotationConverter _converter;

    [SetUp]
    public void Setup()
    {
        _converter = new FunctionalPositionalNotationConverter();
    }

    [Test]
    public void Convert_ShouldReturnZero_ForAllZeroes()
    {
        var convertedValue = _converter.Convert("0000");
        Assert.That(convertedValue, Is.EqualTo(0));
    }

    [Test]
    public void Convert_ShouldHandleSingleDigitBinaryInput()
    {
        var convertedZeroValue = _converter.Convert("0");
        Assert.That(convertedZeroValue, Is.EqualTo(0));

        var convertedOneValue = _converter.Convert("1");
        Assert.That(convertedOneValue, Is.EqualTo(1));
    }

    [Test]
    public void Convert_ShouldReturnCorrectValue_ForValidBinaryInput()
    {
        var convertedResult = _converter.Convert("101110011");
        Assert.That(convertedResult, Is.EqualTo(371));
    }

    [Test]
    public void Convert_ShouldReturnCorrectValue_ForMaximumBinaryInput()
    {
        var convertedResult = _converter.Convert(new string('1', 63));
        Assert.That(convertedResult, Is.EqualTo(Math.Pow(2, 63) - 1));
    }
}