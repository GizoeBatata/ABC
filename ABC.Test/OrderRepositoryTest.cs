using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABC.BS;

namespace ABC.Test
{
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void CheckOrder()
        {
            //arrange
            OrderRepository orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = DateTimeOffset.Now

            };

            //act
            var real = orderRepository.Retrieve(10);
            //assert

            Assert.AreEqual<DateTimeOffset>(expected.OrderDate, real.OrderDate);
      

        }
    }
}
