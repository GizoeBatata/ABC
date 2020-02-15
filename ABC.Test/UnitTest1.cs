using ABC.BS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ABC.Test
{
    [TestClass]
    public class UnitTest1
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
            //input
            Customer customer = new Customer();
            customer.LastName = "Kazan";

            string expected = "Kazan";
            //compare value

            string realvalue = customer.FullName;
            //Asserting
            Assert.AreEqual(expected, realvalue);
        }
    }
}
