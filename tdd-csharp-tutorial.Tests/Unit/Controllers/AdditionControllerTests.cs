using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using tdd_csharp_tutorial.Controllers;
using tdd_csharp_tutorial.Models;

namespace tdd_csharp_tutorial.Tests.Unit.Controllers
{
    [TestClass]
    public class AdditionControllerTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestGetIndex()
        {
            AdditionController testSubject = new AdditionController();
            ViewResult result = testSubject.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    "|DataDirectory|\\TestData\\AdditionData.csv",
                    "AdditionData#csv",
                    DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestPostIndex()
        {
            int? expected = TestContext.DataRow["Expected"] as int?;
            AdditionViewModel model = new AdditionViewModel()
            {
                First = TestContext.DataRow["First"] as int?,
                Second = TestContext.DataRow["Second"] as int?
            };
            AdditionController testSubject = new AdditionController();

            ViewResult result = testSubject.Index(model) as ViewResult;

            Assert.IsNotNull(result.Model);
            Assert.IsInstanceOfType(result.Model, typeof(AdditionViewModel));
            Assert.AreEqual(expected, ((AdditionViewModel)result.Model).Result);
        }
    }
}
