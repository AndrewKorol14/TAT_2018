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
            var enteredString = Console.ReadLine();
            if (enteredString == "")
            {
                Console.WriteLine("Exception message: string hasn't any symbols.");
                return;
            }
            EvenIndexSymbols EvenIndexString = new EvenIndexSymbols();
            Console.WriteLine(EvenIndexString.DeleteSymbolsWithOddIndex(enteredString));
        }
    }
}
