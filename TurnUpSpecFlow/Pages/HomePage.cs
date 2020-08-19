using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TurnUpSpecFlow.Pages
{
    public class HomePage : BasePage
    {
      //  private IWebDriver driver;

        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        //Navigate to Portal up New TM record Page
        public void NavigateToTM()
        {
            // Find and Click on administration 
            IWebElement admindrop = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admindrop.Click();
            Thread.Sleep(1000);

            // Find and click on Time & Material page
            IWebElement matdrop = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            matdrop.Click();
            Thread.Sleep(1000);

        }
               
        //Navigate to Employee Page
        public void NavigateToEmployee()
        {
            // Find and Click on administration 
            IWebElement admindrop = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admindrop.Click();
            Thread.Sleep(1000);

            // Find and click on Employee page
            IWebElement matdrop = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            matdrop.Click();
            Thread.Sleep(1000);
        }

        //Find and Click on create button

        public void ClickOnCreate(IWebDriver driver)
        {
            IWebElement createbtn = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createbtn.Click();
        }

        //Find and Click on Save Button
        public void ClickOnSave(IWebDriver driver)
        {
            IWebElement save = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            save.Click();
        }

        //Function of finding and click on last page
        public void LastPage(IWebDriver driver)
        {
            IWebElement lastpg = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]"));
            lastpg.Click();

        }
    }
}
