﻿using System;
using System.Text;

namespace TaskDEV3
{
    /// <summary>
    /// Converts decimal number in other numeral system
    /// </summary>
    public class ConverterInNewSystem
    {
        uint numberInOldSystem;
        uint numeralSystemBase;

        public ConverterInNewSystem(uint oldSystemNumber, uint systemBase)
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
            if (numeralSystemBase < 2 || numeralSystemBase > 20)
            {
                throw new ArgumentOutOfRangeException("Exception message: wrong base of new numeral system.");
            }
            StringBuilder newSystemNumberString = new StringBuilder();
            uint tempDivisionRemainder;
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
                    char tempCharSymbol = (char)('A' + tempDivisionRemainder - 10); 
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
            char[] reverseString=stringArgument.ToCharArray();
            Array.Reverse(reverseString);
            return new string(reverseString);
        }
    }
}