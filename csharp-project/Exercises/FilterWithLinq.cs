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
            return numbers.Where(n => n > 0);
        }
        
        public static IEnumerable<int> KeepNegativeNumbers(IEnumerable<int> numbers)
        {
            return numbers.Where(n => n < 0);
        }
// { autofold
    }
}
// }