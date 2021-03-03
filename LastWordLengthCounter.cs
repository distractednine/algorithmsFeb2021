using System;

namespace dotNetCoreVsTest
{
    public class LastWordLengthCounter
    {
        public int GetLengthWithSplit(string wordInput)
        {
            if (String.IsNullOrEmpty(wordInput)) {
                throw new ArgumentException();
            }

            var splitStrings = wordInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return splitStrings[splitStrings.Length-1].Trim().Length;
        }

        public int GetLengthWithCounter(string wordInput)
        {
            var count = 0;
            var spaceEncountered = false;

            for (var i = 0; i < wordInput.Length; i++) {
                var currentChar = wordInput[i];

                if(currentChar != ' ')
                {
                    if(spaceEncountered)
                    {
                        count = 0;
                        spaceEncountered = false;
                    }

                    count++;
                } else
                {
                    spaceEncountered = true;
                }
            }

            return count;
        }
    }
}
