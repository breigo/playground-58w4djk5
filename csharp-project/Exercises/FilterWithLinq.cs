// { autofold
using System;
using System.Collections.Generic;
using System.Linq;

namespace Answer
{
    public class FilterWithLinq
    {
// }
        public static IEnumerable<int> KeepPositiveNumbers(IEnumerable<int> numbers)
        {
            var positiveNumbers = numbers.Where(n => n > 0);
            return positiveNumbers;
        }
// { autofold
    }
}
// }