using System;

namespace TaskDEV3
{
    /// <summary>
    /// Class EntryPoint
    /// must get two string arguments, else process exceptions
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            if(args.Length!=2)
            {
                Console.WriteLine("Exception message: wrong number of arguments(should be two arguments).");
                return;
            }

            if (args[0]==String.Empty||args[1]==String.Empty)
            {
                Console.WriteLine("Exception message: something string hasn't any symbols.");
                return;
            }

            int checkingNumber;
            if (!Int32.TryParse(args[0], out checkingNumber)||!Int32.TryParse(args[1], out checkingNumber))
            {
                Console.WriteLine("Exception message: string of decimal number or string of base new numeral system contains wrong symbols.");
                return;
            }

            if (Convert.ToInt16(args[1])<2||Convert.ToInt16(args[1])>20)
            {
                Console.WriteLine("Exception message: wrong base of new numeral system.");
                return;
            }
            NewNumeralSystemInterpreter newSystemNumber = new NewNumeralSystemInterpreter(Int32.Parse(args[0]), Int32.Parse(args[1]));
            Console.Write("Number in new numeral system: ");
            Console.WriteLine(newSystemNumber.ReverseNumberInNewSystem(newSystemNumber.CreateNumberInNewNumeralSystem()));
        }
    }
}
