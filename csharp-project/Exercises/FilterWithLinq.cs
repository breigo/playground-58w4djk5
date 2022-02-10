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
            return numbers.Where(x => x > 0);
        }
        
        public static IEnumerable<int> KeepNegativeNumbers(IEnumerable<int> numbers)
        {
            return numbers.Where(x => x < 0);
        }
// { autofold
    }
}
// }