// { autofold

using System;
using System.Collections.Generic;

namespace Answer
{
    public class FilterWithLambdaExpression
    {
// }
        public static IEnumerable<int> KeepPositiveNumbers(IEnumerable<int> numbers)
        {
            Func<int, bool> isGreaterThanZero = n => n > 0;

            var positiveNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (isGreaterThanZero(number))
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