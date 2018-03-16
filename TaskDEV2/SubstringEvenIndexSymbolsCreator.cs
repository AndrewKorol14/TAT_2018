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
            if (string.IsNullOrEmpty(stringForNewSubstring))
            {
                throw new System.ArgumentException("Exception message: string hasn't any symbols.");
            }
            StringBuilder changingString = new StringBuilder();
            for (int i = 0; i < stringForNewSubstring.Length; i+=2)  
            {
                changingString.Append(stringForNewSubstring[i]); 
            }
            return changingString.ToString(); 
        }
    }
}