// { autofold
using System;
using System.Collections.Generic;
using System.Linq;

namespace Answer
{
    public class SelectFirstAdultWithLinq
    {
// }
        public Person GetFirstAdult(IEnumerable<Person> people)
        {
            return people.First(p => p.Age >= 30);
        }
// { autofold
    }
}
// }