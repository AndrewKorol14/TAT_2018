using System;
using System.IO;

namespace Task3
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                FilesFormatChecker checker = new FilesFormatChecker();
                args[1] = checker.GetTrueFormat(args[1]);              
                string[] files = Directory.GetFiles(args[0], args[1], SearchOption.AllDirectories);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch(UnauthorizedAccessException)
            {
                Console.WriteLine("You must have administrative rights");
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine("Such directory not found");
            }
        }
    }
}