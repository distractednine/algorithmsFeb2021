using System.Runtime.Intrinsics.X86;
using System.Collections.Generic;
using System.Linq;
using System;

public class ReversePolishNotationCalculator
{
    private string operatorsString = "+-*/";

    public int CalculateReversePolishNotation(string itemsString)
    {
        var itemsArray = itemsString?.Split(",", StringSplitOptions.RemoveEmptyEntries);

        if (itemsArray == null || !itemsArray.Any())
        {
            throw new ArgumentException(nameof(itemsString));
        }

        var list = new List<int>();

        for (var i = 0; i < itemsArray.Length; i++)
        {
            var curItem = itemsArray[i].Trim();

            if (operatorsString.Contains(curItem))
            {
                if (list.Count < 2)
                {
                    throw new ArgumentException("the operator has invalid position!");
                }

                var operatorSign = curItem.ToCharArray().First();
                var first = list[list.Count - 2];
                var second = list[list.Count - 1];
                list = list.Take(list.Count - 2).ToList();

                var result = CalculateOperation(first, second, operatorSign);

                list.Add(result);
            }
            else if (int.TryParse(curItem.ToString(), out var parsedNumber))
            {
                list.Add(parsedNumber);
            }
            else
            {
                throw new ArgumentException("invalid character detected!");
            }
        }

        if (list.Count != 1)
        {
            throw new ArgumentException("invalid arguments were passed!");
        }

        return list.First();
    }

    private int CalculateOperation(int first, int second, char operatorSign)
    {
        return operatorSign switch
        {
            '+' => first + second,
            '-' => first - second,
            '*' => first * second,
            '/' => first / second,
            _ => throw new ArgumentException("invalid operator detected!")
        };
    }
}