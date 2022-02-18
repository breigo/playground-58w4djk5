using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Answer;

namespace TechIo
{
    public static class TechIO
    {
        // Display a custom message in a custom channel
        public static void PrintMessage(String channel, String message)
        {		
            Console.WriteLine ($"TECHIO> message --channel \"{channel}\" \"{message}\"");
        }
        // You can manually handle the success/failure of a testcase using this function
        public static void Success(Boolean success)
        {
            Console.WriteLine($"TECHIO> success {success}");
        }
        // Check the user code looking for a keyword
        public static Boolean ExistsInFile(String path, String keyword) 
        {
            return File.ReadAllText(path).Contains(keyword);
        }

        public static void PrintMessage(string channel, IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                PrintMessage(channel, "<null>");
            }
            else
            {
                if (!numbers.Any()) {
                    PrintMessage(channel, "<empty>");
                }
                else
                {
                    var stringNumbers = numbers.Select(n => n.ToString()).ToArray();
                    PrintMessage(channel, string.Join(", ", stringNumbers));
                }
            }
        }

        public static void PrintMessage(string channel, Person person)
        {
            if (person == null)
            {
                PrintMessage(channel, "<null>");
            }
            else
            {
                PrintMessage(channel, $"{person.Name} ({person.Age})");
            }
        }

        public static void PrintMessage(string channel, IEnumerable<Person> people)
        {
            if (people == null)
            {
                PrintMessage(channel, "<null>");
                return;
            }

            if (!people.Any()) {
                PrintMessage(channel, "<empty>");
                return;
            }

            foreach (var person in people)
            {
                PrintMessage(channel, person);
            }
        }

        public static void PrintMessage(string channel, IEnumerable<string> strings)
        {
            if (strings == null)
            {
                PrintMessage(channel, "<null>");
                return;
            }

            if (!strings.Any()) {
                PrintMessage(channel, "<empty>");
                return;
            }

            foreach (var str in strings)
            {
                PrintMessage(channel, str);
            }
        }
    }
}