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

        public static void PrintMessage(string channel, IEnumerable<Person> people)
        {
            if (people == null)
            {
                PrintMessage(channel, "<null>");
                return;
            }

            foreach (var person in people)
            {
                PrintMessage(channel, $"{person.Name} ({person.Age})");
            }
        }
    }
}