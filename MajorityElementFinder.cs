using System.Collections.Generic;
using System;
using System.Linq;

namespace dotNetCoreVsTest
{
    public class MajorityElementFinder<T>
            where T : IComparable<T>
    {
        public ICollection<T> FindMajorityElementsWithDictionary(IEnumerable<T> items)
        {
            var itemsArray = items.ToArray();
            var dictionary = new Dictionary<T, int>();

            for (var i = 0; i < itemsArray.Length; i++)
            {
                var item = itemsArray[i];

                if (dictionary.ContainsKey(item))
                {
                    dictionary[item]++;
                }
                else
                {
                    dictionary[item] = 1;
                }
            }

            var maxOccuranceCount = dictionary.Max(x => x.Value);

            var majorityElements =
                dictionary.Where(x => x.Value == maxOccuranceCount)
                .Select(x => x.Key)
                .ToArray();

            return majorityElements;
        }

        public ICollection<T> FindMajorityElementsWithLinq(IEnumerable<T> items)
        {
            var groupedElements =
               items.Select(x => x)
                   .GroupBy(x => x)
                   .Select(x => new { Key = x.Key, Cnt = x.Count() })
                   .OrderByDescending(x => x.Cnt)
                   .ToArray();

            var maxElementCount =
                groupedElements.Count(x => x.Cnt == groupedElements[0].Cnt);

            var majorityElements =
                groupedElements.Select(x => x.Key)
                    .Take(maxElementCount)
                    .ToArray();

            return majorityElements;
        }

        public ICollection<T> FindMajorityElementWithMooreAlgorithm(IEnumerable<T> items)
        {
            var itemsArray = items.ToArray();
            T candidate = itemsArray[0];
            var counter = 1;

            for (var i = 1; i < itemsArray.Length; i++)
            {
                var item = itemsArray[i];

                if (candidate.CompareTo(item) == 0)
                {
                    counter++;
                }
                else
                {
                    counter--;

                    if (counter == 0)
                    {
                        candidate = item;
                        counter = 1;
                    }
                }
            }

            return new[] { candidate };
        }

    }
}