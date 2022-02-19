// { autofold
using System;
using System.Collections.Generic;
using System.Linq;

namespace Answer
{
    public class FilterPeopleWithLinq
    {
// }
        public IEnumerable<Person> KeepAdults(IEnumerable<Person> people)
        {
            return people.Where(p => p.Age >= 30);
        }
// { autofold
    }
}
// }