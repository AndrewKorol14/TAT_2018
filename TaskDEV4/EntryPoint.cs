using System;
using System.Collections.Generic;

namespace TaskDEV4
{
    /// <summary>
    /// Gets way to the XML-document
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                XmlFileParser fileParser = new XmlFileParser(args[0]);
                fileParser.ParseXmlFile();
                SorterListData sorterList = new SorterListData();
                List<CreatorXmlElements> fileData = new List<CreatorXmlElements>();
                fileData = sorterList.SortElementsAndTags(fileParser);
                foreach (CreatorXmlElements data in fileData)
                {
                    data.OutputXmlElements();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}