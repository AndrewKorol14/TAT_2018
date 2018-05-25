using System;
using System.Collections.Generic;

namespace TaskDEV6
{
    /// <summary>
    /// Create menu of commands
    /// </summary>
    public class CommandMenuCreator
    {
        /// <summary>
        /// Choose the command in menu
        /// </summary>
        public void CommandMenu()
        {
            List<ProductCreator> products = new List<ProductCreator>();
            ProductStore store;
            bool isSuccess = true;
            while (isSuccess)
            {
                Console.WriteLine("Enter the command for products (add product, count types, count all, average price, average price type)...");
                string commandString = Console.ReadLine();
                switch (commandString)
                {
                    case "add product":
                        products.Add(AddProduct());
                        break;
                    case "count types":
                        store = new ProductStore(products, new CounterTypes());
                        Console.WriteLine("Number of types: " + store.CountByCommand(products));
                        break;
                    case "count all":
                        store = new ProductStore(products, new CounterAll());
                        Console.WriteLine("Number of all products: " + store.CountByCommand(products));
                        break;
                    case "average price":
                        store = new ProductStore(products, new CounterAveragePrice());
                        Console.WriteLine("Average price of all products: " + store.CountByCommand(products));
                        break;
                    case "average price type":
                        Console.WriteLine("Enter the type of product for calculation of average price...");
                        string typeForAveragePrice = Console.ReadLine();
                        store = new ProductStore(ChooseTypeOfProduct(typeForAveragePrice, products), new CounterAveragePrice());
                        Console.WriteLine("Average price for one type product: " + store.CountByCommand(products));
                        break;
                    case "exit": 
                        isSuccess = false;
                        break;
                    default:
                        throw new Exception("Wrong command of menu");
                }
            }
        }

        /// <summary>
        /// Enters information about product
        /// </summary>
        /// <returns>New product</returns>
        public ProductCreator AddProduct()
        {
            Console.WriteLine("Enter the type of product...");
            string typeString = Console.ReadLine();
            Console.WriteLine("Enter the name of product...");
            string nameString = Console.ReadLine();
            Console.WriteLine("Enter the quantity of product...");
            string quantityNumber = Console.ReadLine();
            Console.WriteLine("Enter the price of product...");
            string priceNumber = Console.ReadLine();
            return new ProductCreator(typeString, nameString, quantityNumber, priceNumber);
        }

        /// <summary>
        /// Choose the type of product for count average price
        /// </summary>
        /// <param name="stringArgument">Needed type</param>
        /// <param name="list">List of added products</param>
        /// <returns>New list for counting of average price of type</returns>
        private List<ProductCreator> ChooseTypeOfProduct(string stringArgument, List<ProductCreator> list)
        {
            List<ProductCreator> tempList = new List<ProductCreator>();
            tempList.AddRange(list);
            for (int i=0; i<tempList.Count; i++)
            {
                if (!Equals(tempList[i].ProductType, stringArgument))
                {
                    tempList.Remove(tempList[i]);
                }
            }
            return tempList;
        }
    }
}