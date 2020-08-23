using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TurnUpSpecFlow.Helper
{
    class WaitHelper
    {
       // generic function to wait for an element to be clickable
        public static void WaitClickable(IWebDriver driver, string attribute, string value, int seconds)
        {
            try
            {
                if (attribute == "Id")
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.Id(value)));

                }
                if (attribute == "XPath")
                {
                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(value)));

                }
                if (attribute == "CSSSelector")
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(value)));

                }

            }
            catch (Exception ex)
            {
                Assert.Fail("Unable to click web element", ex.Message);
            }
        }

        public static void WaitExists(IWebDriver driver, string attribute, string value, int seconds)
        {
            try
            {
                if (attribute == "Id")
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(value)));
                }
                if (attribute == "XPath")
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(value)));
                }
                if (attribute == "CSSSelector")
                {
                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(value)));
                }

            }
            catch (Exception ex)
            {
                Assert.Fail("Couldn't Find Element", ex.Message);
            }
        }
    }
}
