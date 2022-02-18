using System.Collections.Generic;

namespace Answer
{
    public static class People
    {
        public static IEnumerable<Person> Instance
        {
            get
            {
                return new List<Person>()
                {
                    new Person() { Name = "Samina Stephenson", Age = 9 },
                    new Person() { Name = "Jaydon Heath", Age = 82 },
                    new Person() { Name = "Imaani Macgregor", Age = 66 },
                    new Person() { Name = "Caiden Leonard", Age = 52 },
                    new Person() { Name = "Ubaid Mckeown", Age = 41 },
                    new Person() { Name = "Tomi Cassidy", Age = 52 },
                    new Person() { Name = "Amanpreet Simon", Age = 29 },
                    new Person() { Name = "Miles Cantrell", Age = 2 },
                    new Person() { Name = "Maizie Dominguez", Age = 67 },
                    new Person() { Name = "Ivy-Rose Ingram", Age = 33 },
                };
            }
        }
    }
}