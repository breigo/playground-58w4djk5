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
        /// We first order the list by age (ascending) and then by name (descending).
        /// </summary>
        /// <param name="people">A collection of person objects</param>
        /// <returns>A collection of person objects</returns>
        public IEnumerable<Person> SortByNameAndAge(IEnumerable<Person> people)
        {
            return people
                .OrderBy(p => p.Age)
                .ThenByDescending(p => p.Name);
        }
// { autofold
    }
}
// }