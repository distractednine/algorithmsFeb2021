using System.Collections.Generic;
using System;


namespace dotNetCoreVsTest
{
    public class StringReverser
    {
        private readonly char[] splitChars = new []{' ', ',', '.'};

        public string ReverseSentence(string sentenceInput)
        {
            if (String.IsNullOrEmpty(sentenceInput)) {
                throw new ArgumentException();
            }

            var splitWords = sentenceInput.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

            var wordsCount = splitWords.Length;

            var opCount = wordsCount / 2;

            for (int i = 0; i < opCount; i++)
            {
                var rightIndex = wordsCount - i - 1;
                var left = splitWords[i];
                var right = splitWords[rightIndex];

                splitWords[i] = right;
                splitWords[rightIndex] = left;
            }

            return String.Join(" ", splitWords);
        }
    }
}

