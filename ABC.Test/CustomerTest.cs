﻿using ABC.BS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC.Test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //input
            Customer customer = new Customer();
            customer.FirstName = "Hans";
            customer.LastName = "Kazan";

            string expected = "Kazan, Hans";
            //compare value

            string realvalue = customer.FullName;
            //Asserting
            Assert.AreEqual(expected, realvalue);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //input
            Customer customer = new Customer();
            customer.FirstName = "Hans";
            string expected = "Hans";
            //compare value

            string realvalue = customer.FullName;
            //Asserting
            Assert.AreEqual(expected, realvalue);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            Customer customer = new Customer();
            customer.LastName = "Kazan";

            string expected = "Kazan";
            //Act

            string realvalue = customer.FullName;
            //Assert
            Assert.AreEqual(expected, realvalue);
        }



        

            

        }
    [TestClass]
    public class Unittest2 {
        [TestMethod]
        public void statictest()
        {
            var c1 = new Customer();
            Customer.instanceCount += 1;

            Customer c2 = new Customer();
            Customer.instanceCount += 1;

            Customer c3 = new Customer();
            Customer.instanceCount += 1;


            Assert.AreEqual(3, Customer.instanceCount);

        }
    }

    [TestClass]
    public class Unittest3
    {
      [TestMethod]
        public void trueValidate()
        {
            //Act
            var customer4 = new Customer();
            customer4.EmailAddress = "hans@gmail.com";
            customer4.LastName = "Anders";

            //Arrange
            bool expected = true;
            //Assert
            Assert.AreEqual(expected, customer4.Validate());

        }

        [TestMethod]
        public void missingLnameValidate()
        {
            //Act
            var customer4 = new Customer();
            customer4.EmailAddress = "hans@gmail.com";
           

            //Arrange
            bool expected = true;
            //Assert
            Assert.AreEqual(expected, customer4.Validate());

        }
        [TestMethod]
        public void missingEmailAddressValidate()
        {
            //Act
            var customer4 = new Customer();
            customer4.LastName = "Anders";
           

            //Arrange
            bool expected = true;
            //Assert
            Assert.AreEqual(expected, customer4.Validate());

        }

       [TestClass]
       public class ProductTest
        {
            [TestMethod]
        public void Validate()
            {
                //act
                Product product = new Product();
                product.ProductName = "Shampoo";
                product.CurrentPrice = 10.34M;
                bool expected = true;
                //arrange
               bool real= product.Validate();
                //assert
                Assert.AreEqual(expected, real);
            }
            [TestMethod]
            public void FullProduct()
            {
                //act

                Product product1 = new Product();
                product1.ProductName = "Banaan";
                product1.Description = "Fresh from Jamaica !";
                string expected = "Banaan Fresh from Jamaica !";
                //arrange
                string real = product1.FullProduct();

                //assert
                Assert.AreEqual(expected, real);
            }

        }
        [TestClass]
        public class OrderTest
        {
            [TestMethod]
            public void ValidateOrderDate()
            {
                //act
                Order order = new Order();
                order.OrderDate = System.DateTime.Now;
                bool expected = true;
                //arrange
                bool real = order.Validate();
                //assert
                Assert.AreEqual(expected, real);
            }

        }

    }

    [TestClass]
    public class OrderItemTest
    {
        [TestMethod]

        public void OrderItemValidate()
        {
            //act
            OrderItem orderItem = new OrderItem();
            orderItem.OrderQuantity = 10;
            orderItem.PurchasePrice = 99.99M;
            orderItem.ProductId = 10;

            bool expected = true;
            //arr
            bool real=orderItem.Validate();
            //assert
            Assert.AreEqual(expected, real);



        }


    }
}
