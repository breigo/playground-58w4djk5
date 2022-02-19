// { autofold
using System;
using System.Collections.Generic;
using System.Linq;

namespace Answer
{
    public class SelectNamesWithLinq
    {
// }
        /// <summary>
        /// Returns a collection of names.
        /// </summary>
        /// <param name="people">A collection of person objects</param>
        /// <returns>A collection of strings containing the names of each person</returns>
        public IEnumerable<string> GetNames(IEnumerable<Person> people)
        {
            return people
                .Select(p => p.Name);
        }
// { autofold
    }
}
// }