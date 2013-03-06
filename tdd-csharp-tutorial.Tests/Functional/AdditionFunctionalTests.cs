using Microsoft.VisualStudio.TestTools.UnitTesting;
using tdd_csharp_tutorial.Tests.Functional.Pages;

namespace tdd_csharp_tutorial.Tests.Functional
{
    [TestClass]
    public class AdditionFunctionalTests : FunctionalBase
    {
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
                    "|DataDirectory|\\TestData\\AdditionData.csv", 
                    "AdditionData#csv", 
                    DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestAdditon()
        {
            string first = TestContext.DataRow["First"] as string;
            string second = TestContext.DataRow["Second"] as string;
            string expected = TestContext.DataRow["Expected"] as string;

            WebDriver.Navigate().GoToUrl(GetAbsoluteUrl("/Addition"));
            AdditionPage page = PageBase.GetInstance<AdditionPage>(WebDriver, "Add numbers and stuff");

            page = page.Add(first, second);

            Assert.AreEqual<string>(expected, page.Result.GetAttribute("value"));
        }
    }
}
