namespace RomanNumerals
{
    public static class RomanNumeralsConverter
    {
        public static string ToRomanNumerals(this int value) =>
            new string('I', value)
                .SubstituteGroup('I', 5, 'V', null)
                .SubstituteGroup('V', 2, 'X', 'I')
                .SubstituteGroup('X', 5, 'L', 'V')
                .SubstituteGroup('L', 2, 'C', 'X')
                .SubstituteGroup('C', 5, 'D', 'L')
                .SubstituteGroup('D', 2, 'M', 'C');

        private static string SubstituteGroup(this string input, char numeral, int groupSize, char nextNumeral, char? previousNumeral) => groupSize switch
        {
            -1 => input.Replace($"{numeral}{previousNumeral}{numeral}", $"{previousNumeral}{nextNumeral}"),
            2 => input.Replace(new string(numeral, groupSize), nextNumeral.ToString()).SubstituteGroup(numeral, -1, nextNumeral, previousNumeral),
            4 => input.Replace(new string(numeral, groupSize), $"{numeral}{nextNumeral}"),
            5 => input.Replace(new string(numeral, groupSize), nextNumeral.ToString()).SubstituteGroup(numeral, 4, nextNumeral, previousNumeral),
            _ => input
        };

        public static int FromRomanNumerals(this string value) =>
            value.Tally('M', 1000, 'C', 100)
                 .Tally('D', 500, 'C', 100) 
                 .Tally('C', 100, 'X', 10)
                 .Tally('L', 50, 'X', 10)
                 .Tally('X', 10, 'I', 1)
                 .Tally('V', 5, 'I', 1)
                 .Length;

        private static string Tally(this string input, char numeral, int score, char deductionNumeral, int deductionScore) =>
            input.ToUpper()
                 .Replace($"{deductionNumeral}{numeral}", new string(TALLY_CHARACTER, score - deductionScore))
                 .Replace(numeral.ToString(), new string(TALLY_CHARACTER, score));

        private const char TALLY_CHARACTER = '|';
    }
}
