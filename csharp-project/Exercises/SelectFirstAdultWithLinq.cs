// { autofold
using System;
using System.Collections.Generic;
using System.Linq;

namespace Answer
{
    public class SelectFirstAdultWithLinq
    {
// }
        /// <summary>
        /// Returns the first adult found in the collection
        /// We define an adult as a person who is at least 30 years on earth.
        /// </summary>
        /// <param name="people">A collection of person objects</param>
        /// <returns>A (single) person object</returns>
        public static Person GetFirstAdult(IEnumerable<Person> people)
        {
            return people.First(p => p.Age >= 30);
        }
// { autofold
    }
}
// }