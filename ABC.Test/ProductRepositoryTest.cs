using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ABC.BS;

namespace ABC.Test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void CheckProduct()
        {
            //arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
            ProductName = "Shampoo",
            Description = "Product for washing hair",
            CurrentPrice = 12.45M

        };


            //act
            var real = productRepository.Retrieve(2);
            //assert
            Assert.AreEqual(expected.ProductId,real.ProductId);
            Assert.AreEqual(expected.ProductName, real.ProductName);
            Assert.AreEqual(expected.Description, real.Description);
            Assert.AreEqual(expected.CurrentPrice, real.CurrentPrice);

        }
    }
}
