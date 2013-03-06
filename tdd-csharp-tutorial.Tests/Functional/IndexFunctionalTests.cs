using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tdd_csharp_tutorial.Tests.Functional
{
    [TestClass]
    public class IndexFunctionalTests : FunctionalBase
    {
        [TestMethod]
        public void TestIndexWelcome()
        {
            WebDriver.Navigate().GoToUrl(GetAbsoluteUrl("/"));
            Assert.AreEqual<string>("Welcome", WebDriver.Title, 
                                    "The title of the index page doesn't match");
            Assert.IsTrue(WebDriver.PageSource.Contains("Hello, World!"));
        }
    }
}
