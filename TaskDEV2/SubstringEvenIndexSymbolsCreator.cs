using System.Text;

namespace TaskDEV2
{
    /// <summary>
    /// Class SubstringEvenIndexSymbolsCreator
    /// findes elements of string with even indexes 
    /// </summary>
    public class SubstringEvenIndexSymbolsCreator
    {
        /// <summary>
        /// Store for entered string
        /// </summary>
        string stringForNewSubstring;

        /// <summary>
        /// The class SubstringEvenIndexSymbolsCreator constructor
        /// for field initialization 
        /// </summary>
        /// <param name="stringArgument">Entered string</param>
        public SubstringEvenIndexSymbolsCreator(string stringArgument)
        {
            stringForNewSubstring = stringArgument;
        }

        /// <summary>
        /// Method CreateSubstringFromOddSymbols
        /// return the substring, which contain even index symbols (odd symbols)   
        /// </summary>
        /// <returns>Substring with even index symbols</returns>
        public string CreateSubstringFromOddSymbols()
        {
            StringBuilder changingString = new StringBuilder(stringForNewSubstring);
            for (int i = 1; i < changingString.Length; i++) //when symbols with even index are deleted, symbols of the string shifts on one index 
            {
                changingString.Remove(i, 1); 
            }
            return changingString.ToString(); 
        }
    }
}