using System.Text;

namespace TaskDEV2
{
    /// <summary>
    /// Class EvenIndexSymbols
    /// findes elements of string with even indexes 
    /// </summary>
    class EvenIndexSymbols
    {
        /// <summary>
        /// Method DeleteSymbolsWithOddIndex
        /// return the string, which contain even index symbols in stringArgument  
        /// </summary>
        /// <param name="stringArgument">Inputted string</param>
        /// <returns>String with even index symbols</returns>
        public string DeleteSymbolsWithOddIndex(string stringArgument)
        {
            StringBuilder changingString = new StringBuilder(stringArgument);
            for (int i = 1; i < changingString.Length; i++) //when symbols with even index are deleted, symbols of the string shifts on one index 
            {
                changingString.Remove(i, 1); 
            }
            stringArgument = changingString.ToString();
            return stringArgument;
        }
    }
}