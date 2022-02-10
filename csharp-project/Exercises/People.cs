using System.Collections.Generic;

namespace Answer
{
    public static class People
    {
        public static IEnumerable<Person> Instance
        {
            get
            {
                return new List<Person>();
            }
        }
    }
}