using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace tdd_csharp_tutorial.Tests.Functional.Pages
{
    public class AdditionPage : PageBase
    {
        [FindsBy(How = How.Id, Using = "First")]
        public IWebElement First { get; set; }

        [FindsBy(How = How.Id, Using = "Second")]
        public IWebElement Second { get; set; }

        [FindsBy(How = How.Id, Using = "Result")]
        public IWebElement Result { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[type=submit]")]
        IWebElement SubmitButton { get; set; }

        public AdditionPage Add(string first, string second)
        {
            First.Clear();
            First.SendKeys(first);

            Second.Clear();
            Second.SendKeys(second);

            SubmitButton.Click();

            return GetInstance<AdditionPage>(Driver, ExpectedTitle);
        }
    }
}