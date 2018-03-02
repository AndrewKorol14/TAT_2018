using System;

namespace TaskDEV1
{
    /// <summary>
    /// Class MaxNumberSerialSymbols
    /// searches maximum number of same serial symbols in the string
    /// and searches some exceptions
    /// </summary>
    class MaxNumberSerialSymbols
    {
        static void Main(string[] args)
        {
            try
            {
                if(args.Length != 1)
                {
                    throw new Exception("method must get only one string.");
                }
            }
            catch (Exception exceptionArgument)
            {
                Console.WriteLine("Exception message: " + exceptionArgument.Message);
                return;
            }
            var enteringString=args[0].ToCharArray();
            MaxNumberSerialSymbols EntryPointObject = new MaxNumberSerialSymbols();
            Console.WriteLine("Max number of symbols: "+EntryPointObject.FindMaxNumberSymbols(enteringString));
        }
        /// <summary>
        /// Method FindMaxNumberSymbols
        /// searches maximum number of same serial symbols in the string
        /// </summary>
        /// <param name="stringArgument">String, which was inputed</param>
        /// <returns>Maximum number of same serial symbols in the string</returns>
        int FindMaxNumberSymbols(char[] stringArgument)
        {
            int maxNumber = 0;
            int tempMaxNumber = 0;
            for (int i = 0; i < stringArgument.Length - 1; i++)
            {
                if (stringArgument[i] == stringArgument[i + 1])
                {
                    tempMaxNumber++;
                }
                else
                {
                    tempMaxNumber = 0;
                }

                if (tempMaxNumber > maxNumber)
                {
                    maxNumber = tempMaxNumber;
                }
            }
            return maxNumber + 1;
        }
    }
}
