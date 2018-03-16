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
            try
            {
                string enteredString = Console.ReadLine();
                SubstringEvenIndexSymbolsCreator EvenIndexSubstring = new SubstringEvenIndexSymbolsCreator(enteredString);
                Console.WriteLine(EvenIndexSubstring.CreateSubstringFromOddSymbols());
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}