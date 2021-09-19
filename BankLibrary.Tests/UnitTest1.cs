using BankingLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calculate_AcceptsPNR_ReturnsSI()
        {
            int ExpectedResult = 1000;
            ICalcInterest c = new CalcInterest();
            int ActualResult = c.Calculate(10000, 1, 10);
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}
