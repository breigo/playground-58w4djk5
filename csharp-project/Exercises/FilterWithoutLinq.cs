// { autofold

using System;
using System.Collections.Generic;

namespace Answer
{
    public class FilterWithoutLinq
    {
// }
        public IEnumerable<int> KeepPositiveNumbers(IEnumerable<int> numbers)
        {
            var positiveNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    positiveNumbers.Add(number);
                }
            }

            return positiveNumbers;
        }
// { autofold
    }
}
// }