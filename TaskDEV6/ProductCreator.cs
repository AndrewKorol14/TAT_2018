using System;
using System.Threading;

namespace TaskDEV6
{
    /// <summary>
    /// Create product with some information
    /// </summary>
    public class ProductCreator
    {
        string typeOfProduct;
        string nameOfProduct;
        int quantityOfProducts;
        double priceOfProduct;
        
        public ProductCreator(string typeOfProduct, string nameOfProduct, string quantityOfProducts, string priceOfProduct)
        {
            this.typeOfProduct = typeOfProduct;
            this.nameOfProduct = nameOfProduct;
            this.quantityOfProducts = Int32.Parse(quantityOfProducts);
            if (this.quantityOfProducts <= 0)
            {
                throw new ArgumentException("Quantity of products must be positive");
            }
            char separatorOfRealValue = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!Double.TryParse(priceOfProduct, out this.priceOfProduct))
            {
                priceOfProduct = priceOfProduct.Replace('.', separatorOfRealValue);
                priceOfProduct = priceOfProduct.Replace(',', separatorOfRealValue);
            }
            this.priceOfProduct = Double.Parse(priceOfProduct);
            if (this.priceOfProduct <= 0.0)
            {
                throw new ArgumentException("Price of products must be positive");
            }
        }

        public string ProductType
        {
            get { return typeOfProduct; }
        }

        public string ProductName
        {
            get { return nameOfProduct; }
        }

        public int ProductQuantity
        {
            get { return quantityOfProducts; }
        }

        public double ProductPrice
        {
            get { return priceOfProduct; }
        }
    }
}