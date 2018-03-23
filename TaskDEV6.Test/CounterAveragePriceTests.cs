using System.Collections.Generic;
using NUnit.Framework;

namespace TaskDEV6.Test
{
    [TestFixture]
    class CounterAveragePriceTests
    {
        [TestCase(8.75)]
        public void CountByCommandTest_CalculateAveragePrice_AveragePrice(double expectedValue)
        {
            List<ProductCreator> list = new List<ProductCreator>();
            list.Add(new ProductCreator("toy", "Dog", "2", "15"));
            list.Add(new ProductCreator("pencil", "Red", "5", "5"));
            list.Add(new ProductCreator("toy", "Cat", "1", "15"));
            CommandMenuCreator menu = new CommandMenuCreator();
            ProductStore storage = new ProductStore(list, new CounterAveragePrice());
            double actualQuantity = storage.CountByCommand(list);
            Assert.AreEqual(expectedValue, actualQuantity);
        }

        [TestCase((double)15)]
        public void CountByCommandTestForOne_CalculateAveragePrice_AveragePrice(double expectedValue)
        {
            List<ProductCreator> list = new List<ProductCreator>();
            list.Add(new ProductCreator("toy", "Dog", "10", "15"));
            CommandMenuCreator menu = new CommandMenuCreator();
            ProductStore storage = new ProductStore(list, new CounterAveragePrice());
            double actualQuantity = storage.CountByCommand(list);
            Assert.AreEqual(expectedValue, actualQuantity);
        }
    }
}
