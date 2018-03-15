using System;

namespace TaskDEV4
{
    /// <summary>
    /// Create elements from XML-document
    /// </summary>
    class CreatorXmlElements
    {
        string elementName;
        string tagElement;
        string valueElement;

        public CreatorXmlElements(string elementArgument, string tagArgument, string valueArgument)
        {
            elementName = elementArgument;
            tagElement = tagArgument;
            valueElement = valueArgument;
        }
        
        public string Element
        {
            get { return elementName; }
        }

        public string Tag
        {
            get { return tagElement; }
        }

        /// <summary>
        /// Output the values of class fields
        /// </summary>
        public void OutputXmlElements()
        {
            Console.Write(elementName + " - " + tagElement + " - " + valueElement);
            Console.WriteLine();
        }
    }
}