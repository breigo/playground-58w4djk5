// { autofold
using System;
using System.Collections.Generic;
using System.Linq;

namespace Answer
{
    public class SelectNamesWithLinq
    {
// }
        public IEnumerable<string> GetNames(IEnumerable<Person> people)
        {
            return people
                .Select(p => p.Name);
        }
// { autofold
    }
}
// }