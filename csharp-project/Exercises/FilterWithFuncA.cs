// { autofold

using System;
using System.Collections.Generic;

namespace Answer
{
    public class FilterWithFuncA
    {
// }
        public static bool IsGreaterThanZero(int x)
        {
            return x > 0;
        }

        public static IEnumerable<int> KeepPositiveNumbers(IEnumerable<int> numbers)
        {
            Func<int, bool> greaterZero = IsGreaterThanZero;
            return FilterNumbers(numbers, greaterZero);
        }

        public static IEnumerable<int> FilterNumbers(IEnumerable<int> numbers, Func<int, bool> filterPredicate)
        {
            var filteredNumbers = new List<int>();
            
            foreach (var number in numbers)
            {
                if (filterPredicate(number))
                {
                    filteredNumbers.Add(number);
                }
            }

            return filteredNumbers;
        }
// { autofold
    }
}
// }