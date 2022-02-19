// { autofold
using System;
using System.Collections.Generic;
using System.Linq;

namespace Answer
{
    public class SortPeopleWithLinq
    {
// }
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