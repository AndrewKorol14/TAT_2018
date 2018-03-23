using System;
using System.Collections.Generic;

namespace TaskDEV6
{
    /// <summary>
    /// Redefines method of counter of all products inherited from the interface
    /// </summary>
    class CounterAll : ICounter
    {
        /// <summary>
        /// Count all added products
        /// </summary>
        /// <param name="list">List of added products</param>
        public void CountByCommand(List<ProductCreator> list)
        {
            int counterAllProducts = 0;
            foreach(ProductCreator i in list)
            {
                counterAllProducts += i.ProductQuantity;
            }
            Console.WriteLine(counterAllProducts);
        }
    }
}