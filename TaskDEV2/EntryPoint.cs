using System;

namespace TaskDEV2
{
    /// <summary>
    /// Class EntryPoint
    /// gets the string from console
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string enteredString = Console.ReadLine();
            if (string.IsNullOrEmpty(enteredString))
            {
                Console.WriteLine("Exception message: string hasn't any symbols.");
                return;
            }
            SubstringEvenIndexSymbolsCreator EvenIndexSubstring = new SubstringEvenIndexSymbolsCreator(enteredString);
            Console.Write("Substring: ");
            Console.WriteLine(EvenIndexSubstring.CreateSubstringFromOddSymbols());
        }
    }
}
