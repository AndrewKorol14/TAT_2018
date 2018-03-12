using System.Collections.Generic;

namespace TaskDEV4
{
    /// <summary>
    /// Sorts data by elements and tags
    /// </summary>
    class SorterListData
    {
        /// <summary>
        /// Sorts the data by elements then by tags
        /// </summary>
        /// <param name="fileParser">Parser of XML-document</param>
        /// <returns>List of sort data</returns>
        public List<CreatorXmlElements> SortElementsAndTags(XmlFileParser fileParser)
        {
            List<CreatorXmlElements> tempFileData = new List<CreatorXmlElements>();
            Queue<string> fileElements = fileParser.GetXmlElement();
            Queue<string> fileTags = fileParser.GetXmlTag();
            Queue<string> fileValues = fileParser.GetXmlValue();

            while (fileElements.Count > 0)
            {
                tempFileData.Add(new CreatorXmlElements(fileElements.Dequeue(), fileTags.Dequeue(), fileValues.Dequeue()));
            }
            tempFileData.Sort(delegate (CreatorXmlElements firstDataElement, CreatorXmlElements secondDataElement)
            {
                return firstDataElement.Tag.CompareTo(secondDataElement.Tag);
            });
            tempFileData.Sort(delegate (CreatorXmlElements firstDataElement, CreatorXmlElements secondDataElement)
            {
                return (firstDataElement.Element.CompareTo(secondDataElement.Element));
            });
            return tempFileData;
        }
    }
}