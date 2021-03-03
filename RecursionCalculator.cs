using System;
using System.Linq;
using System.Collections.Generic;

namespace dotNetCoreVsTest
{
    public class RecursionCalculator
    {
        public double CalculateFactorial(int number)
        {
            return number == 1 ?
                1 :
                number * CalculateFactorial(number - 1);
        }

        public double CalculateFibonacci(int number)
        {
            return (number == 1 || number == 0) ?
                number :
                CalculateFibonacci(number - 1) + CalculateFibonacci(number - 2);
        }

        public double CalculatePower(int number, int power)
        {
            return power == 1 ?
                number :
                number * CalculatePower(number, power - 1);
        }

        public double CalculateNumberOfDigits(string numberStr)
        {
            return numberStr.Length == 1 ?
                1 :
                1 + CalculateNumberOfDigits(numberStr.Substring(0, numberStr.Length - 1));
        }

        public double Multiply(int number1, int number2)
        {
            return number2 == 1 ?
                number1 :
                number1 + Multiply(number1, number2 - 1);
        }

        public int CountZerosInString(string str)
        {
            if (str.Length == 0)
            {
                return 0;
            }
            else
            {
                if (str[0] == '0')
                {
                    return 1 + CountZerosInString(str.Substring(1, str.Length - 1));
                }
                else
                {
                    return CountZerosInString(str.Substring(1, str.Length - 1));
                }
            }
        }

        public bool CheckIfArrayIsSorted(int[] array)
        {
            if (array.Length < 2)
            {
                throw new ArgumentException(nameof(array));
            }

            return CheckIfArrayIsSortedInternal(array, array.Length - 1);
        }

        private bool CheckIfArrayIsSortedInternal(int[] array, int index)
        {
            if (index == 0)
            {
                return true;
            }

            return array[index] > array[index - 1] && CheckIfArrayIsSortedInternal(array, index - 1);
        }

        public int CalculateSumOfArray(int[] array)
        {
            if (array.Length < 2)
            {
                throw new ArgumentException(nameof(array));
            }

            return CalculateSumOfArrayInternal(array, array.Length - 1);
        }

        private int CalculateSumOfArrayInternal(int[] array, int index)
        {
            if (index == 0)
            {
                return array[0];
            }

            return array[index] + CalculateSumOfArrayInternal(array, index - 1);
        }

        public bool CheckElementIsPresentInArray(int[] array, int elementToFind)
        {
            if (array.Length < 2)
            {
                throw new ArgumentException(nameof(array));
            }

            return CheckElementIsPresentInArrayInternal(array, array.Length - 1, elementToFind);
        }

        private bool CheckElementIsPresentInArrayInternal(int[] array, int index, int elementToFind)
        {
            if (index == 0)
            {
                return array[0] == elementToFind;
            }

            return array[index] == elementToFind ||
                CheckElementIsPresentInArrayInternal(array, index - 1, elementToFind);
        }

        public int FindFirstIndexOfElement(int[] array, int elementToFind)
        {
            if (array.Length < 2)
            {
                throw new ArgumentException(nameof(array));
            }

            return FindFirstIndexOfElementInternal(array, array.Length - 1, elementToFind);
        }

        private int FindFirstIndexOfElementInternal(int[] array, int index, int elementToFind)
        {
            if (index == 0)
            {
                return array[index] == elementToFind ?
                    index : -1;
            }

            var lastIndex = FindFirstIndexOfElementInternal(array, index - 1, elementToFind);

            if (array[index] == elementToFind)
            {
                return (lastIndex > index || lastIndex == -1) ?
                    index : lastIndex;
            }

            return lastIndex;
        }

        public int FindLastIndexOfElement(int[] array, int elementToFind)
        {
            if (array.Length < 2)
            {
                throw new ArgumentException(nameof(array));
            }

            return FindLastIndexOfElementInternal(array, array.Length - 1, elementToFind);
        }

        private int FindLastIndexOfElementInternal(int[] array, int index, int elementToFind)
        {
            if (array[index] == elementToFind)
            {
                return index;
            }
            if (index == 0)
            {
                return -1;
            }

            return FindLastIndexOfElementInternal(array, index - 1, elementToFind);
        }

        public int CountNumbersOfElementsInArray(int[] array, int elementToFind)
        {
            if (array.Length < 2)
            {
                throw new ArgumentException(nameof(array));
            }

            return CountNumbersOfElementsInArrayInternal(array, array.Length - 1, elementToFind, 0);
        }

        private int CountNumbersOfElementsInArrayInternal(int[] array, int index, int elementToFind, int count)
        {
            if (array[index] == elementToFind)
            {
                count++;
            }
            if (index == 0)
            {
                return count;
            }

            return CountNumbersOfElementsInArrayInternal(array, index - 1, elementToFind, count);
        }

        public bool CheckPalindromeString(string stringToCheck)
        {
            if (stringToCheck.Length < 2)
            {
                throw new ArgumentException(nameof(stringToCheck));
            }

            var charArray = stringToCheck.ToCharArray();

            return CheckPalindromeStringInternal(charArray, 0, charArray.Length - 1);
        }

        private bool CheckPalindromeStringInternal(char[] charArray, int firstIndex, int lastIndex)
        {
            Console.WriteLine($"Checking: {firstIndex} - {lastIndex}");

            if (firstIndex >= lastIndex)
            {
                return charArray[firstIndex] == charArray[lastIndex];
            }
            if (charArray[firstIndex] != charArray[lastIndex])
            {
                return false;
            }

            return CheckPalindromeStringInternal(charArray, firstIndex + 1, lastIndex - 1) &&
                CheckPalindromeStringInternal(charArray, firstIndex + 2, lastIndex - 2);
        }

        public void Print(string stringToPrint)
        {
            if (stringToPrint.Length < 2)
            {
                throw new ArgumentException(nameof(stringToPrint));
            }

            var charArray = stringToPrint.ToCharArray();

            PrintInternal(charArray, charArray.Length - 1);
        }

        private void PrintInternal(char[] charArray, int index)
        {
            if (index == 0)
            {
                return;
            }

            PrintInternal(charArray, --index);
            Console.WriteLine(charArray[index]);
        }

        public void PrintReverse(string stringToPrint)
        {
            if (stringToPrint.Length < 2)
            {
                throw new ArgumentException(nameof(stringToPrint));
            }

            var charArray = stringToPrint.ToCharArray();

            PrintReverseInternal(charArray, charArray.Length - 1);
        }

        private void PrintReverseInternal(char[] charArray, int index)
        {
            Console.WriteLine(charArray[index]);

            if (index == 0)
            {
                return;
            }

            PrintReverseInternal(charArray, --index);
        }

        public int GetStringLength(string targetString)
        {
            if (targetString.Length < 2)
            {
                throw new ArgumentException(nameof(targetString));
            }

            var charArray = targetString.ToCharArray();

            var result = GetStringLengthInternal(charArray, charArray.Length - 1);

            return result;
        }

        private int GetStringLengthInternal(char[] charArray, int index)
        {
            if (index == 0)
            {
                return 1;
            }

            return 1 + GetStringLengthInternal(charArray, --index);
        }

    }
}