using ClientApp;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using WebAPI.Controllers;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DisplayData_Positive()
        {
            //Arrange

            //Act
          
            ServiceAPI obj = new ServiceAPI();
            Program p = new Program();
            Mock<ServiceAPI> s = new Mock<ServiceAPI>();
            s.Setup(x => x.ServiceCall("Read"));

           // string data = s.Object.DisplayData();
            //Asset
            Assert.AreEqual(s.ToString(), "Hello World");

        }


        
        //[TestMethod]
        //public void MessageControllerTest_Positive()
        //{
        //    // Arrange
        //    var controller = new MessageController();
            

        //    // Act
        //    var response = controller.getMessage();

        //    // Assert
           
        //    Assert.AreEqual("Hello World", response);
        //}
    }

   

}
