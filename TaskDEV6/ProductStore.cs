using System.Collections.Generic;

namespace TaskDEV6
{
    /// <summary>
    /// Create storage for products
    /// </summary>
    class ProductStore
    {
        List<ProductCreator> productStorage;

        public ProductStore(List<ProductCreator> productStorage, ICounter count)
        {
            this.productStorage = productStorage;
            Countable = count;
        }

        public ICounter Countable
        {
            private get;
            set;
        }

        public double CountByCommand(List<ProductCreator> list)
        {
            return Countable.CountByCommand(productStorage);
        }
    }
}