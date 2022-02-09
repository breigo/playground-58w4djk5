// { autofold

using System.Collections.Generic;

namespace Answer
{
    public class FilterWithoutLinq
    {
// }
        public static IEnumerable<int> KeepPositiveNumbers(IEnumerable<int> numbers)
        {
            var positiveNumbers = new List<int>();

            foreach (var number in numbers)
            {
                if (IsGreaterThanZero(number))
                {
                    positiveNumbers.Add(number);
                }
            }

            return positiveNumbers;
        }

        private static bool IsGreaterThanZero(int i)
        {
            return i > 0;
        }
// { autofold
    }
}
// }