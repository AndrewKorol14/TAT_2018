using System;

namespace TaskDEV1
{
    /*
     * Class for search maximum number of same serial symbols in the string and
     * search some exceptions
     */
    class MaxNumberSerialSymbols
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)     //Check number of arguments(one or not one) 
            {
                Console.WriteLine("Too much or too few arguments");
                return;
            }
           var enteringString =args[0].ToCharArray();
           MaxNumberSerialSymbols EntryPointObject = new MaxNumberSerialSymbols();
           Console.WriteLine("Max number of symbols: "+EntryPointObject.FindMaxNumberSymbols(enteringString));
        }
        /*
         * Method for search maximum number of same serial symbols in the string
         */
        int FindMaxNumberSymbols(char[] stringArgument)
        {
            int maxNumber = 0;
            int temp = 0;
            for (int i = 0; i < stringArgument.Length - 1; i++)
            {
                if (stringArgument[i] == stringArgument[i + 1])
                {
                    temp++;
                }
                else
                {
                    temp = 0;
                }

                if (temp > maxNumber)
                {
                    maxNumber = temp;
                }
            }
            if (maxNumber == 0)      //Check, exist or doesn't exist sequences of the same symbols
            {
                Console.WriteLine("No sequences of the same symbols");
                return 0;
            }
            else
            {
                return maxNumber + 1;
            }
        }
    }
}
