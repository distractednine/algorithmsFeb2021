using System.Text.RegularExpressions;
using System.Linq;
using System;

namespace dotNetCoreVsTest
{
    public class ExcelSheetColumnCalculator
    {
        private const int alphabetCharsNumber = 26;
        private const int firstLetterCode = 97;
        private readonly string chars;

        public ExcelSheetColumnCalculator()
        {
            var charEnumerable = 
                Enumerable.Range(0, alphabetCharsNumber)
                    .Select(x => (char)(x + firstLetterCode));
            chars = string.Join("", charEnumerable);
        }

        public int CalculateColumnNumber(string columnName)
        {
            if (string.IsNullOrWhiteSpace(columnName))
            {
                throw new ArgumentException(nameof(columnName));
            }

            var charsArray = columnName.ToCharArray();
            var result = 0;

            for (int i = 0; i < charsArray.Length; i++)
            {
                var currentChar = char.ToLowerInvariant(charsArray[i]);
                var currentCharIndex = chars.IndexOf(currentChar) + 1;

                if (currentCharIndex < 0)
                {
                    throw new ArgumentException("invalid character in column name detected!");
                }

                var power = charsArray.Length - i - 1;
                var number = (int) Math.Pow(alphabetCharsNumber, power) * currentCharIndex;

                result += number;
            }

            return result;
        }
    }
}
