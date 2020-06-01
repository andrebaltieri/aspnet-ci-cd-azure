using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shop.Domain;

namespace Shop.Domain.Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExpectToGetErrorWhenPriceIsZero()
        {
            var order = new Order(0);
        }

        [TestMethod]
        public void ExpectToGenerateOrderNumber()
        {
            var order = new Order(1000);
            Assert.IsFalse(string.IsNullOrEmpty(order.Number));
        }
    }
}
