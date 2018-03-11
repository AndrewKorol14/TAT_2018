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
                uint tempDecimalNumber = UInt32.Parse(args[0]);
                uint tempSystemBase = UInt32.Parse(args[1]);
                if (tempSystemBase < 2 || tempSystemBase > 20)
                {
                    throw new ArgumentOutOfRangeException("Exception message: wrong base of new numeral system.");
                }
                ConverterInNewSystem newSystemNumber = new ConverterInNewSystem(UInt32.Parse(args[0]), UInt32.Parse(args[1]));
                Console.Write("Number in new numeral system: ");
                Console.WriteLine(newSystemNumber.ReverseNumberInNewSystem(newSystemNumber.CreateNumberInNewNumeralSystem()));
            }
            catch(FormatException)
            {
                Console.WriteLine("Exception message: strings contain wrong symbols or null.");
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.ParamName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}