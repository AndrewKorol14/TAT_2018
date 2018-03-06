using System;
using System.Text;

namespace TaskDEV3
{
    /// <summary>
    /// Class NewNumeralSystemInterpreter
    /// interprets decimal number in other numeral system
    /// </summary>
    public class NewNumeralSystemInterpreter
    {
        int numberInOldSystem;
        int numeralSystemBase;

        public NewNumeralSystemInterpreter(int oldSystemNumberArgument, int systemBaseArgument)
        {
            numberInOldSystem = oldSystemNumberArgument;
            numeralSystemBase = systemBaseArgument;
        }

        /// <summary>
        /// Method CreateNumberInNewNumeralSystem
        /// represents decimal number in new numeral system
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
                    char tempCharSymbol = (char)(tempDivisionRemainder + 48); //using ASCII table, for choosing next numeral in the number of new numeral system
                    newSystemNumberString.Append(tempCharSymbol.ToString());
                }
                else
                {
                    char tempCharSymbol = (char)(tempDivisionRemainder + 55); //using ASCII table, for choosing next numeral in the number of new numeral system
                    newSystemNumberString.Append(tempCharSymbol.ToString());
                }
            } while (numberInOldSystem > 0);
            return newSystemNumberString.ToString();
        }

        /// <summary>
        /// Method ReverseNumberInNewSystem
        /// reverses backward string
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
