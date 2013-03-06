using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace tdd_csharp_tutorial.Tests.Functional.Pages
{
    public class PageBase
    {
        public IWebDriver Driver { get; set; }
        public string ExpectedTitle { get; set; }

        public static TPage GetInstance<TPage>(IWebDriver driver, string expectedTitle) where TPage : PageBase, new()
        {
            TPage pageInstance = new TPage()
            {
                ExpectedTitle = expectedTitle,
                Driver = driver
            };
            PageFactory.InitElements(driver, pageInstance);

            Assert.AreEqual(pageInstance.ExpectedTitle, driver.Title);

            return pageInstance;
        }
    }
}