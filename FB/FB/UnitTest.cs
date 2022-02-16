using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using FB.Controllers;
using NUnit.Framework;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using Moq;

namespace FB
{
    [TestClass]
    public class UnitTest
    {
        FBController controller = new FBController();
        Database data = new Database();


        [TestMethod]
        public void testApi()
        {
            string actual = controller.GetFIZZBUZZString(3, 4);

            if(string.Compare(actual, "FIZZ,4") == 0)
            {
                NUnit.Framework.Assert.Pass();
            }
            else
            {
                NUnit.Framework.Assert.Fail();
            }
        }

        //Mock
        [TestMethod]
        public void verifyDatabase()
        {
            //Assuming GetBuzzResultOnly method is not implemented completly.
            Mock<Database> mck = new Mock<Database>();

            //Actual methods returns null
            mck.Setup(t => t.verifyData().Returns("buzz"));

        }
    }
}
