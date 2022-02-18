// { autofold
using System;
using System.Collections.Generic;
using System.Linq;

namespace Answer
{
    public class SortPeopleWithLinq
    {
// }
        /// <summary>
        /// Returns a sorted collection of people.
        ///
        /// We first order the collection by name (ascending) and then by age (descending).
        /// </summary>
        /// <param name="people">A collection of person objects</param>
        /// <returns>A collection of person objects</returns>
        public static IEnumerable<Person> SortByNameAndAge(IEnumerable<Person> people)
        {
            return people
                .OrderBy(p => p.Name)
                .ThenByDescending(p => p.Age);
        }
// { autofold
    }
}
// }