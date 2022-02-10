// { autofold
using System;
using System.Collections.Generic;
using System.Linq;

namespace Answer
{
    public class FilterPeopleWithLinq
    {
// }
        /// <summary>
        /// Returns only adults.
        /// We define an adult as a person who is at least 30 years on earth.
        /// </summary>
        /// <param name="people">A collection of person objects</param>
        /// <returns>A collection of person objects</returns>
        public static IEnumerable<Person> KeepAdults(IEnumerable<Person> people)
        {
            return people.Where(p => p.Age >= 30);
        }
// { autofold
    }
}
// }