using NUnit.Framework;

namespace RomanNumerals.Tests
{
    class RomanNumeralsConverterTests
    {
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(11, "XI")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(16, "XVI")]
        [TestCase(19, "XIX")]
        [TestCase(20, "XX")]
        [TestCase(21, "XXI")]
        [TestCase(30, "XXX")]
        [TestCase(40, "XL")]
        [TestCase(49, "XLIX")]
        [TestCase(50, "L")]
        [TestCase(51, "LI")]
        [TestCase(57, "LVII")]
        [TestCase(74, "LXXIV")]
        [TestCase(90, "XC")]
        [TestCase(100, "C")]
        [TestCase(139, "CXXXIX")]
        [TestCase(400, "CD")]
        [TestCase(500, "D")]
        [TestCase(666, "DCLXVI")]
        [TestCase(888, "DCCCLXXXVIII")]
        [TestCase(900, "CM")]
        [TestCase(1000, "M")]
        [TestCase(1666, "MDCLXVI")]
        [TestCase(3999, "MMMCMXCIX")]
        public void ConvertsNumberToNumeralString(int value, string expected)
        {
            var actual = value.ToRomanNumerals();
            Assert.AreEqual(expected, actual);
        }

        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
        [TestCase("VI", 6)]
        [TestCase("VII", 7)]
        [TestCase("VIII", 8)]
        [TestCase("IX", 9)]
        [TestCase("X", 10)]
        [TestCase("XI", 11)]
        [TestCase("XIV", 14)]
        [TestCase("XV", 15)]
        [TestCase("XVI", 16)]
        [TestCase("XIX", 19)]
        [TestCase("XX", 20)]
        [TestCase("XXI", 21)]
        [TestCase("XXX", 30)]
        [TestCase("XL", 40)]
        [TestCase("XLIX", 49)]
        [TestCase("L", 50)]
        [TestCase("LI", 51)]
        [TestCase("LVII", 57)]
        [TestCase("LXXIV", 74)]
        [TestCase("XC", 90)]
        [TestCase("C", 100)]
        [TestCase("CXXXIX", 139)]
        [TestCase("CD", 400)]
        [TestCase("D", 500)]
        [TestCase("DCLXVI", 666)]
        [TestCase("DCCCLXXXVIII", 888)]
        [TestCase("CM", 900)]
        [TestCase("M", 1000)]
        [TestCase("MDCLXVI", 1666)]
        [TestCase("MMMCMXCIX", 3999)]

        public void ConvertsNumeralStringToNumber(string value, int expected)
        {
            var actual = value.FromRomanNumerals();
            Assert.AreEqual(expected, actual);
        }

        [TestCase("i", 1)]
        [TestCase("ii", 2)]
        [TestCase("iii", 3)]
        [TestCase("mmmcmxcix", 3999)]
        public void ConvertsLowerCaseNumeralStringToNumber(string value, int expected)
        {
            var actual = value.FromRomanNumerals();
            Assert.AreEqual(expected, actual);
        }
    }
}