using System;
using System.Collections.Generic;

namespace TaskDEV6
{
    /// <summary>
    /// Redefines method of counter of product types inherited from the interface
    /// </summary>
    class CounterTypes : ICounter
    {
        /// <summary>
        /// Count types added products
        /// </summary>
        /// <param name="list">List of added products</param>
        public void CountByCommand(List<ProductCreator> list)
        {
            int counter = list.Count;
            List<ProductCreator> tempList = new List<ProductCreator>();
            tempList.AddRange(list);
            for (int i = 0; i < tempList.Count - 1; i++)
            {
                for (int j = i + 1; j < tempList.Count; j++)
                {
                    if (Equals(tempList[i].ProductType, tempList[j].ProductType))
                    {
                        tempList.Remove(tempList[j]);
                    }
                }
            }          
            Console.WriteLine(tempList.Count);
        }
    }
}