using NUnit.Framework;

namespace RomanNumerals.Tests
{
    public class ConverterTests
    {
        [TestCase("XXVI", 26)]
        [TestCase("MM", 2000)]
        public void Converter_Convert_WithSimpleNumerals_ReturnsCorrectValue(string input, int expected)
        {
            // Assemble
            var sut = new Converter();

            // Act
            var actual = sut.Convert(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("MCM", 1900)]
        public void Converter_Convert_WithComplexNumerals_ReturnsCorrectValue(string input, int expected)
        {
            // Assemble
            var sut = new Converter();

            // Act
            var actual = sut.Convert(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("xxvi", 26)]
        [TestCase("mm", 2000)]
        public void Converter_Convert_WithLowerCaseCaseNumerals_ReturnsCorrectValue(string input, int expected)
        {
            // Assemble
            var sut = new Converter();

            // Act
            var actual = sut.Convert(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}