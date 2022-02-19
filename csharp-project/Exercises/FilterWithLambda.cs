// { autofold

using System;
using System.Collections.Generic;

namespace Answer
{
    public class FilterWithLambda
    {
// }
        public IEnumerable<int> KeepPositiveNumbers(IEnumerable<int> numbers)
        {
            Func<int, bool> greaterZero = x => x > 0;
            return FilterNumbers(numbers, greaterZero);
        }
        
        public IEnumerable<int> KeepNegativeNumbers(IEnumerable<int> numbers)
        {
            return FilterNumbers(numbers, x => x < 0);
        }

        public IEnumerable<int> FilterNumbers(IEnumerable<int> numbers, Func<int, bool> filterPredicate)
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