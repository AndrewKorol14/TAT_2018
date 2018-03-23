using System;
using NUnit.Framework;

namespace TaskDEV6.Test
{
    [TestFixture]
    public class CommandMenuCreatorTests
    {
        [TestCase("toy", "Dog", "-10", "5,5")]
        [TestCase("toy", "Dog", "10", "-5,5")]
        [TestCase("toy", "Dog", "-10", "-5,5")]
        public void ProductCreatorArgumentTest_AddProductInformation_NewProduct(string actualType, string actualName, string actualQuantity, string actualPrice)
        {
            Assert.Throws<ArgumentException>(() => new ProductCreator(actualType, actualName, actualQuantity, actualPrice));
        }

        [TestCase("toy", "Dog", "1a0", "5,5")]
        [TestCase("toy", "Dog", "10", "5,a5")]
        [TestCase("toy", "Dog", "1a0", "5,a5")]
        public void ProductCreatorFormatTest_AddProductInformation_NewProduct(string actualType, string actualName, string actualQuantity, string actualPrice)
        {
            Assert.Throws<FormatException>(() => new ProductCreator(actualType, actualName, actualQuantity, actualPrice));
        }

        [TestCase("toy", "Dog", "2147483648", "5,5")]
        [TestCase("toy", "Dog", "-2147483649", "5,5")]
        public void ProductCreatorOverflowTest_AddProductInformation_NewProduct(string actualType, string actualName, string actualQuantity, string actualPrice)
        {
            Assert.Throws<OverflowException>(() => new ProductCreator(actualType, actualName, actualQuantity, actualPrice));
        }

    }
}
