using System;
using Xunit;

namespace TaskDEV2.Test
{
    public class SubstringEvenIndexSymbolsCreatorTests
    {
        [Theory]
        [InlineData("Abcde  fghijk -@#4winner!!!12345", "Ace gik-#wne!!24")]
        [InlineData("1", "1")]
        public void CreateSubstringFromOddSymbols_deleteEvenSymbols_OddSymbols(String inputtedValue, String expectedResult)
        {
            SubstringEvenIndexSymbolsCreator EvenIndexTest = new SubstringEvenIndexSymbolsCreator(inputtedValue);
            String actualValue = EvenIndexTest.CreateSubstringFromOddSymbols();
            Assert.Equal(expectedResult, actualValue);
        }

        [Theory]
        [InlineData("")]
        public void CreateSubstringFromOddSymbols_WrongFormat_Exception(String inputtedValue)
        {
            SubstringEvenIndexSymbolsCreator EvenIndexTest = new SubstringEvenIndexSymbolsCreator(inputtedValue);
            Assert.Throws<ArgumentException>(() => EvenIndexTest.CreateSubstringFromOddSymbols());
        }
    }
}