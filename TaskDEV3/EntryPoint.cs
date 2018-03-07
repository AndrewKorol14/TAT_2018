using System;

namespace TaskDEV3
{
    /// <summary>
    /// Must get two string arguments, else process exceptions
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                int tempDecimalNumber = Int32.Parse(args[0]);
                int tempSystemBase = Int32.Parse(args[1]);
            }
            catch(FormatException)
            {
                Console.WriteLine("Exception message: strings contain wrong symbols or null.");
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
