using System;
using WebAPI;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClientApp;

;

namespace UnitTest
{
    public class ClientAppTest
    {
        [TestMethod()]
        public void AddCustomerTest()
        {
            //Arrange

            //Act
            Mock<MyEmail> objEmail = new Mock<MyEmail>();
            objEmail.Setup(x => x.SendEmail()).Returns(true);

            ServiceAPI obj = new ServiceAPI();
            bool IsInserted = obj.AddCustomer(objEmail.Object);

            //Asset
            Assert.AreEqual(IsInserted, true);
            
        }
    }
}
