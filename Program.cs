using System;

namespace dotNetCoreVsTest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // ShowLastWordLengthCounter();

            // ReverseSentence();

            FindBiggestCommonPrefix();

            // FindMajorityElement();

            // CalculateReversePolishNotation();

            // CalculateExcelSheetColumnNumber();

            //CalculateRecursion();
        }

        private static void ReverseSentence()
        {
            var input = "The quick brown fox jumps over the lazy dog";

            Console.WriteLine($"Input: {input}");

            var result = new StringReverser().ReverseSentence(input);

            Console.WriteLine($"Reversed string: {result}");
        }

        private static void ShowLastWordLengthCounter()
        {
            var input = " yy   olol iiii  t, ";

            Console.WriteLine($"Input: {input}");

            var result = new LastWordLengthCounter().GetLengthWithCounter(input);

            Console.WriteLine($"Last word length: {result}");
        }

        private static void FindBiggestCommonPrefix()
        {
            var input = new[] { "flower", "flow", "flight", "f" };

            Console.WriteLine($"Input: {string.Join(",", input)}");

            var result = new CommonPrefixFinder().FindCommonPrefix(input);

            Console.WriteLine($"Biggest common prefix: {result}");
        }

        private static void FindMajorityElement()
        {
            var input = new[] { 1, 4, 4, 7, 4, 4, 7, 4, 4, 4, 4, 3, 7, 7, 7, 7, 4 };

            Console.WriteLine($"Input: {string.Join(",", input)}");

            var result = new MajorityElementFinder<int>().FindMajorityElementWithMooreAlgorithm(input);

            Console.WriteLine($"Majority elements: {string.Join(",", result)}");
        }

        private static void CalculateReversePolishNotation()
        {
            // var input = "3, 4, 5, *, +"; // 23
            // var input = "4, 13, 5, /, +"; // 6
            // var input = "2, 1, +, 3, *"; // 9
            var input = "10, 6, 9, 3, +, -11, *, /, *, 17, +, 5, +"; // 22

            Console.WriteLine($"Input: {input}");

            var result = new ReversePolishNotationCalculator().CalculateReversePolishNotation(input);

            Console.WriteLine($"Reverse Polish notation calculation result: {string.Join(",", result)}");
        }

        private static void CalculateExcelSheetColumnNumber()
        {
            // var input = "AAA"; // 703
            // var input = "AB"; // 28
            var input = "ZY"; // 701

            Console.WriteLine($"Input: {input}");

            var result = new ExcelSheetColumnCalculator().CalculateColumnNumber(input);

            Console.WriteLine($"Excel sheet column number claculation result: {string.Join(",", result)}");
        }

        private static void CalculateRecursion()
        {
            var input = "123456789";

            Console.WriteLine($"Input: {input}");

            var result = new RecursionCalculator().GetStringLength(input);

            Console.WriteLine($"Output: {result}");
        }

        // private static void CountZerosInString(string str)
        // {
        //     var input = 8;

        //     Console.WriteLine($"Input: {input}");

        //     var result = new RecursionCalculator().Multiply(input, 9);

        //     Console.WriteLine($"Output: {string.Join(",", result)}");
        // }
    }
}
