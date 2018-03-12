using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TaskDEV4
{
    /// <summary>
    /// Parses XML-document
    /// </summary>
    class XmlFileParser
    {
        string fileName;
        Queue<string> xmlElement=new Queue<string>();
        Queue<string> xmlTag = new Queue<string>();
        Queue<string> xmlValue = new Queue<string>();

        /// <summary>
        /// Initialize field of way to XML-document
        /// </summary>
        /// <param name="fileArgument">String with way to XML-document</param>
        public XmlFileParser(string fileArgument)
        {
            fileName = fileArgument;
        }

        /// <summary>
        /// Parses XML-document
        /// </summary>
        public void ParseXmlFile()
        {
            try
            {
                using (StreamReader fileReader = new StreamReader(fileName))
                {
                    StringBuilder tempXmlValue = new StringBuilder();
                    StringBuilder tempXmlTag = new StringBuilder();
                    Stack<string> tempXmlElement = new Stack<string>();
                    string[] separatorsForFile = new string[4] { "<", ">", "\r\n","  "};
                    string[] separatorsForAttribute = new string[5] { " ", "=", ">", "\r\n", "  "};

                    string[] xmlData = fileReader.ReadToEnd().Split(separatorsForFile, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < xmlData.Length; i++)
                    {
                        if (xmlData[i] != String.Empty && !xmlData[i].StartsWith("?xml"))
                        {
                            bool isGiven = false;
                            for (int j = i; j < xmlData.Length; j++)
                            {
                                if (xmlData[j] == "/" + xmlData[i])
                                {
                                    SetDataValue(xmlData[i], tempXmlTag, tempXmlElement);
                                    isGiven = true;
                                    break;
                                }
                            }
                            if(isGiven)
                            {
                                continue;
                            }
                            CheckConditionForValue(xmlData[i], tempXmlValue, tempXmlElement, tempXmlTag);
                            if (xmlData[i].Contains("=\"") && xmlData[i].EndsWith("\""))
                            {
                                string[] tempSubs = xmlData[i].Split(separatorsForAttribute, StringSplitOptions.RemoveEmptyEntries);
                                for (int k = 0; k < tempSubs.Length; k++)
                                {
                                    bool isDone = false;
                                    if (tempSubs[k] != String.Empty)
                                    {
                                        for (int j = i + 1; j < xmlData.Length; j++)
                                        {
                                            if (xmlData[j] == "/" + tempSubs[k])
                                            {
                                                SetDataValue(tempSubs[k], tempXmlTag, tempXmlElement);
                                                isDone = true;
                                                break;
                                            }
                                        }
                                        if(isDone)
                                        {
                                            continue;
                                        }
                                        CheckConditionForAttribute(tempSubs[k], tempXmlTag);
                                        CheckConditionForAttributeValue(tempSubs[k], tempXmlValue, tempXmlElement, tempXmlTag);
                                    }
                                }
                            }
                            if (xmlData[i] == "/" + tempXmlElement.Peek())
                            {
                                tempXmlElement.Pop();
                                continue;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Сhecks whether the value is data
        /// </summary>
        /// <param name="dataArgument">String of XML-data</param>
        /// <param name="valueArgument">String of value</param>
        /// <param name="elementArgument">Stack of strings of elements</param>
        /// <param name="tagArgument">String of tags</param>
        public void CheckConditionForValue(string dataArgument, StringBuilder valueArgument, Stack<string> elementArgument, StringBuilder tagArgument)
        {
            if (!dataArgument.Contains("=\"") && !dataArgument.EndsWith("\"") && !dataArgument.StartsWith("/"))
            {
                valueArgument.Remove(0, valueArgument.Length);
                valueArgument.Append(dataArgument);
                SetXmlElements(tagArgument, valueArgument, elementArgument);
            }
        }

        /// <summary>
        /// Сhecks whether the attribute value is data
        /// </summary>
        /// <param name="dataArgument">String of XML-data</param>
        /// <param name="valueArgument">String of attribute value</param>
        /// <param name="elementArgument">Stack of strings of elements</param>
        /// <param name="attributeArgument">String of attribute</param>
        public void CheckConditionForAttributeValue(string dataArgument, StringBuilder valueArgument, Stack<string> elementArgument, StringBuilder attributeArgument)
        {
            if (dataArgument.StartsWith("\"") && dataArgument.EndsWith("\""))
            {
                valueArgument.Remove(0, valueArgument.Length);
                valueArgument.Append(dataArgument);

                SetXmlElements(attributeArgument, valueArgument, elementArgument);
            }
        }

        /// <summary>
        /// Сhecks whether the attribute is data
        /// </summary>
        /// <param name="dataArgument">String of XML-data</param>
        /// <param name="attributeArgument">String of attribute</param>
        public void CheckConditionForAttribute(string dataArgument, StringBuilder attributeArgument)
        {
            if (!dataArgument.StartsWith("\"") && !dataArgument.EndsWith("\""))
            {
                attributeArgument.Remove(0, attributeArgument.Length);
                attributeArgument.Append(dataArgument);
            }
        }

        /// <summary>
        /// Sets data for temp fields of element and tag
        /// </summary>
        /// <param name="dataArgument">String of XML-data</param>
        /// <param name="tagArgument">String of tag</param>
        /// <param name="elementArgument">Stack of strings of elements</param>
        public void SetDataValue(string dataArgument, StringBuilder tagArgument, Stack<string> elementArgument)
        {
            elementArgument.Push(dataArgument);
            tagArgument.Remove(0, tagArgument.Length);
            tagArgument.Append(dataArgument);
        }

        /// <summary>
        /// Sets the fields of class
        /// </summary>
        /// <param name="tagArgument">String of tag</param>
        /// <param name="valueArgument">String of value</param>
        /// <param name="elementArgument">Stack of strings of elements</param>
        public void SetXmlElements(StringBuilder tagArgument, StringBuilder valueArgument, Stack<string> elementArgument)
        {
            if (tagArgument.ToString() != String.Empty && valueArgument.ToString() != String.Empty)
            {
                string[] tempElement = new string[elementArgument.Count];
                StringBuilder elementString = new StringBuilder();
                elementArgument.CopyTo(tempElement, 0);
                for (int j=tempElement.Length-1; j>=0; j--)
                {
                    elementString.Append(tempElement[j]);
                    elementString.Append("/");
                }
                xmlTag.Enqueue(tagArgument.ToString());
                xmlValue.Enqueue(valueArgument.ToString());
                xmlElement.Enqueue(elementString.ToString());
            }
        }

        /// <summary>
        /// Gets field of XML-element
        /// </summary>
        /// <returns>XML-element</returns>
        public Queue<string> GetXmlElement()
        {
            return xmlElement;
        }

        /// <summary>
        /// Gets field of XML-tag
        /// </summary>
        /// <returns>XML-tag</returns>
        public Queue<string> GetXmlTag()
        {
            return xmlTag;
        }

        /// <summary>
        /// Gets field of XML-value
        /// </summary>
        /// <returns>XML-value</returns>
        public Queue<string> GetXmlValue()
        {
            return xmlValue;
        }
    }
}