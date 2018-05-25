using System.Collections.Generic;

namespace TaskDEV6
{
    /// <summary>
    ///  Redefines method of counter of average price of all products
    ///  inherited from the interface
    /// </summary>
    public class CounterAveragePrice : ICounter
    {
        /// <summary>
        /// Count average price of all added products
        /// </summary>
        /// <param name="list">List of added products</param>
        public double CountByCommand(List<ProductCreator> list)
        {
            int counterAllProducts = 0;
            double priceProducts = 0;
            foreach(ProductCreator i in list)
            {
                priceProducts += (i.ProductPrice * i.ProductQuantity);
                counterAllProducts += i.ProductQuantity;
            }
            priceProducts /= counterAllProducts;
            return priceProducts;
        }
    }
}