using System;
using NUnit.Framework;

namespace TaskDEV3.Test
{
    [TestFixture]
    public class ConverterInNewSystemTests
    {
        [TestCase(UInt32.MaxValue, (uint)2, "11111111111111111111111111111111")]
        [TestCase(UInt32.MaxValue, (uint)20, "F4IA3273")]
        [TestCase(UInt32.MinValue, (uint)2, "0")]
        [TestCase(UInt32.MinValue, (uint)20, "0")]
        [TestCase(UInt32.MaxValue, (uint)10, "5927694924")]
        public void CreateNumberInNewNumeralSystem_InNewSystem_NewNumber(uint decimalValue, uint baseValue, string expectedValue)
        {
            ConverterInNewSystem NumberConverter = new ConverterInNewSystem(decimalValue, baseValue);
            String actualValue = NumberConverter.CreateNumberInNewNumeralSystem();
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCase("1234567890", "0987654321")]
        public void ReverseNumberInNewSystem_ReverseString_ReversedString(string newNumber, string expectedValue)
        {
            ConverterInNewSystem NumberConverter = new ConverterInNewSystem((uint)255, (uint)2);
            String actualValue = NumberConverter.ReverseNumberInNewSystem(newNumber);
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCase((uint)255, (uint)21)]
        [TestCase((uint)255,(uint)1)]
        public void CreateNumberInNewNumeralSystem_WrongBase_Exception(uint decimalNumber, uint baseValue)
        {
            ConverterInNewSystem NumberConverter = new ConverterInNewSystem(decimalNumber, baseValue);
            Assert.Throws<ArgumentOutOfRangeException>(() => NumberConverter.CreateNumberInNewNumeralSystem());
        }
    }
}