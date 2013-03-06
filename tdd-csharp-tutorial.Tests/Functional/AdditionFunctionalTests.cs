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
            int? first = TestContext.DataRow["First"] as int?;
            int? second = TestContext.DataRow["Second"] as int?;
            int? expected = TestContext.DataRow["Expected"] as int?;

            WebDriver.Navigate().GoToUrl(GetAbsoluteUrl("/Addition"));
            AdditionPage page = PageBase.GetInstance<AdditionPage>(WebDriver, "Add numbers and stuff");

            page = page.Add(first.ToString(), second.ToString());

            Assert.AreEqual<string>(expected.ToString(), page.Result.GetAttribute("value"));
        }
    }
}
