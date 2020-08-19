using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace TurnUpSpecFlow.Hooks
{
    [Binding]
    public sealed class Hooks
    {

        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "TestResults"));
        }

        [BeforeScenario(Order = 0)]
        public void BeforeScenario()
        {
            GetDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver?.Dispose();
        }

        /// <summary>
        /// Create and initialize driver
        /// </summary>
        /// <returns></returns>

        public IWebDriver GetDriver()
        {
            var browser = "Chrome";

            if (_driver == null)
            {
                switch (browser)
                {
                    case "Chrome":
                        ChromeOptions chromeOptions = new ChromeOptions();

                        // Get value for headless option from appsettings.json

                        var headless = "false";

                        if (headless == "true")
                        {
                            chromeOptions.AddArgument("--headless");
                        }

                        _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), chromeOptions);
                        break;
                }

                try
                {
                    _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    _driver.Manage().Cookies.DeleteAllCookies();
                    _driver.Manage().Window.Maximize();
                    _objectContainer.RegisterInstanceAs(_driver);
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.Message + " Driver failed to initialize");
                }
            }

            return _driver;
        }
    }
}
