using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebServiceDEV11.Test
{
    [TestClass]
    public class GetterDaysServiceTest
    {
        [TestMethod]        
        public void GetDayQuantityTestsNormalDate()
        {
            OurEraDayQuantityRef.GetterDaysService webService = new OurEraDayQuantityRef.GetterDaysService();
            uint actualValue = webService.GetDayQuantity(new DateTime(2008, 3, 1));
            Assert.AreEqual((uint)733101, actualValue);
        }

        [TestMethod]
        public void GetDayQuantityTestsZeroDays()
        {
            OurEraDayQuantityRef.GetterDaysService webService = new OurEraDayQuantityRef.GetterDaysService();
            uint actualValue = webService.GetDayQuantity(new DateTime(0001, 1, 1));
            Assert.AreEqual((uint)0, actualValue);
        }
    }
}