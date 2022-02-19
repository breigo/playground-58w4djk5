// { autofold
using System;
using System.Collections.Generic;
using System.Linq;

namespace Answer
{
    public class FilterPeopleWithWhereAndTake
    {
// }
        public IEnumerable<Person> TakeFirstTwoAdults(IEnumerable<Person> people)
        {
            return people
                .Where(p => p.Age >= 30)
                .Take(2);
        }
// { autofold
    }
}
// }