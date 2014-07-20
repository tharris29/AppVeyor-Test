using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using zip_it_api;
using zip_it_api.Controllers;

namespace zip_it_api.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
