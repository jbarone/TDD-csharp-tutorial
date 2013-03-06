using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using tdd_csharp_tutorial.Controllers;

namespace tdd_csharp_tutorial.Tests.Unit.Controllers
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void TestIndex()
        {
            HomeController testSubject = new HomeController();
            ViewResult result = testSubject.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
