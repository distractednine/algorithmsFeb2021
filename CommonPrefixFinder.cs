using System.Collections.Generic;
using System;
using System.Linq;

namespace dotNetCoreVsTest
{
    public class CommonPrefixFinder
    {
        public string FindCommonPrefix(IEnumerable<string> items)
        {
            if (!items.Any()) {
                throw new ArgumentException();
            }

            var itemsArray = items.ToArray();
            var commonPrefix = "";
            var charIndex = 0;
            var canIterate = true;

            while (canIterate)
            {
                for (var i = 0; i < itemsArray.Count(); i++)
                {
                    var item = itemsArray[i];

                    if (item.Length <= charIndex || item[charIndex] != itemsArray[0][charIndex])
                    {
                        canIterate = false;
                        break;
                    }
                }

                if (canIterate)
                {
                    commonPrefix += itemsArray[0][charIndex];
                    charIndex++;
                }
            }

            return commonPrefix;
        }
    }
}