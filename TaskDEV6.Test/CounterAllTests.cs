using System.Collections.Generic;
using NUnit.Framework;

namespace TaskDEV6.Test
{
    [TestFixture]
    class CounterAllTests
    {
        [TestCase((double)75)]
        public void CountByCommandTestForSeveral_CountAllProducts_NumberOfProducts(double expectedValue)
        {
            List<ProductCreator> list = new List<ProductCreator>();
            list.Add(new ProductCreator("toy", "Dog", "10", "15"));
            list.Add(new ProductCreator("pencil", "Red", "50", "5"));
            list.Add(new ProductCreator("toy", "Cat", "15", "17"));
            CommandMenuCreator menu = new CommandMenuCreator();
            ProductStore storage = new ProductStore(list, new CounterAll());
            double actualQuantity = storage.CountByCommand(list);
            Assert.AreEqual(expectedValue, actualQuantity);
        }

        [TestCase((double)0)]
        public void CountByCommandTestForZero_CountAllProducts_NumberOfProducts(double expectedValue/*List<ProductCreator> list*/)
        {
            List<ProductCreator> list = new List<ProductCreator>();
            CommandMenuCreator menu = new CommandMenuCreator();
            ProductStore storage = new ProductStore(list, new CounterAll());
            double actualQuantity = storage.CountByCommand(list);
            Assert.AreEqual(expectedValue, actualQuantity);
        }

        [TestCase((double)10)]
        public void CountByCommandTestForOne_CountAllProducts_NumberOfProducts(double expectedValue/*List<ProductCreator> list*/)
        {
            List<ProductCreator> list = new List<ProductCreator>();
            list.Add(new ProductCreator("toy", "Dog", "10", "15"));
            CommandMenuCreator menu = new CommandMenuCreator();
            ProductStore storage = new ProductStore(list, new CounterAll());
            double actualQuantity = storage.CountByCommand(list);
            Assert.AreEqual(expectedValue, actualQuantity);
        }
    }
}