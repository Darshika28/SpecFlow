using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TurnUpSpecFlow.Pages
{
    public abstract class BasePage
    {
        protected readonly IWebDriver driver;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Navigate(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public bool IsPageLoaded(By pageLocator)
        {
            try
            {
                return driver.FindElement(pageLocator).Displayed;
            }
            catch (Exception)
            {
                Console.WriteLine($@"No page found with locator: {pageLocator}");
                throw;
            }
        }
    }
}
