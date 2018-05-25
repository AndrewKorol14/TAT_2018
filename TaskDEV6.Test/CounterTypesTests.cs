using System.Collections.Generic;
using NUnit.Framework;

namespace TaskDEV6.Test
{
    [TestFixture]
    class CounterTypesTests
    {
        [TestCase((double)2)]
        public void CountByCommandTestForAlmostDifferent_CountTypes_NumberOfTypes(double expectedValue)
        {
            List<ProductCreator> list = new List<ProductCreator>();
            list.Add(new ProductCreator("toy", "Dog", "10", "15"));
            list.Add(new ProductCreator("pencil", "Red", "50", "5"));
            list.Add(new ProductCreator("toy", "Cat", "15", "17"));
            CommandMenuCreator menu = new CommandMenuCreator();
            ProductStore storage = new ProductStore(list, new CounterTypes());
            double actualQuantity = storage.CountByCommand(list);
            Assert.AreEqual(expectedValue, actualQuantity);
        }

        [TestCase((double)1)]
        public void CountByCommandTestForSimilar_CountTypes_NumberOfTypes(double expectedValue)
        {
            List<ProductCreator> list = new List<ProductCreator>();
            list.Add(new ProductCreator("toy", "Dog", "10", "15"));
            list.Add(new ProductCreator("toy", "Rat", "50", "20"));
            list.Add(new ProductCreator("toy", "Cat", "15", "17"));
            CommandMenuCreator menu = new CommandMenuCreator();
            ProductStore storage = new ProductStore(list, new CounterTypes());
            double actualQuantity = storage.CountByCommand(list);
            Assert.AreEqual(expectedValue, actualQuantity);
        }

        [TestCase((double)0)]
        public void CountByCommandTestForZero_CountTypes_NumberOfTypes(double expectedValue)
        {
            List<ProductCreator> list = new List<ProductCreator>();
            CommandMenuCreator menu = new CommandMenuCreator();
            ProductStore storage = new ProductStore(list, new CounterTypes());
            double actualQuantity = storage.CountByCommand(list);
            Assert.AreEqual(expectedValue, actualQuantity);
        }

        [TestCase((double)3)]
        public void CountByCommandTestForDifferent_CountTypes_NumberOfTypes(double expectedValue)
        {
            List<ProductCreator> list = new List<ProductCreator>();
            list.Add(new ProductCreator("toy", "Dog", "10", "15"));
            list.Add(new ProductCreator("pencil", "Red", "50", "5"));
            list.Add(new ProductCreator("pan", "Black", "55", "6"));
            CommandMenuCreator menu = new CommandMenuCreator();
            ProductStore storage = new ProductStore(list, new CounterTypes());
            double actualQuantity = storage.CountByCommand(list);
            Assert.AreEqual(expectedValue, actualQuantity);
        }
    }
}