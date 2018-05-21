using System;

namespace Task3
{
    /// <summary>
    /// Checker for checking of format correctness
    /// </summary>
    class FilesFormatChecker
    {
        /// <summary>
        /// Converts the inputted format into correct format for function of searching
        /// </summary>
        /// <param name="inputFormat">Inputted format</param>
        /// <returns>Correct format</returns>
        public string GetTrueFormat(string inputFormat)
        {
            if (inputFormat == String.Empty)
            {
                inputFormat = "*.*";
            }
            if (!inputFormat.Contains("*"))
            {
                inputFormat = "*" + inputFormat;
            }
            return inputFormat;
        }
    }
}