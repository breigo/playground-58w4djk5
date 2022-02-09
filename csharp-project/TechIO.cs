using System;
using System.IO;

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
    }
}