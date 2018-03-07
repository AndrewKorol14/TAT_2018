using System;
using System.Text;

namespace TaskDEV3
{
    /// <summary>
    /// Interprets decimal number in other numeral system
    /// </summary>
    public class InterpreterInNewSystem
    {
        int numberInOldSystem;
        int numeralSystemBase;

        public InterpreterInNewSystem(int oldSystemNumber, int systemBase)
        {
            numberInOldSystem = oldSystemNumber;
            numeralSystemBase = systemBase;
        }

        /// <summary>
        /// Represents decimal number in new numeral system
        /// </summary>
        /// <returns>Backward string of number in new system</returns>
        public string CreateNumberInNewNumeralSystem()
        {
            StringBuilder newSystemNumberString = new StringBuilder();
            int tempDivisionRemainder;
            do
            {
                tempDivisionRemainder = numberInOldSystem % numeralSystemBase;
                numberInOldSystem = numberInOldSystem / numeralSystemBase;
                if (tempDivisionRemainder < 10)
                {
                    char tempCharSymbol = (char)(tempDivisionRemainder + '0'); 
                    newSystemNumberString.Append(tempCharSymbol.ToString());
                }
                else
                {
                    char tempCharSymbol = (char)(tempDivisionRemainder + '7'); 
                    newSystemNumberString.Append(tempCharSymbol.ToString());
                }
            } while (numberInOldSystem > 0);
            return newSystemNumberString.ToString();
        }

        /// <summary>
        /// Reverses backward string
        /// </summary>
        /// <param name="stringArgument">Backward string</param>
        /// <returns>Normal string</returns>
        public string ReverseNumberInNewSystem(string stringArgument)
        {
            char[] charArrayForReverse=stringArgument.ToCharArray();
            Array.Reverse(charArrayForReverse);
            return new string(charArrayForReverse);
        }
    }
}
