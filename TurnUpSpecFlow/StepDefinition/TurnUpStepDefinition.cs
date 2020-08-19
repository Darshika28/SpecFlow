using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TurnUpSpecFlow.Pages;

namespace TurnUpSpecFlow.StepDefinition
{
    [Binding]
    public sealed class TurnUpStepDefinition
    {
        //Object
        private readonly LoginPage _LoginPage;
        private readonly HomePage _HomePage;

        //Constructor
        public TurnUpStepDefinition(IWebDriver driver)
        {
            _LoginPage = new LoginPage(driver);
            _HomePage = new HomePage(driver);
        }

        [Given(@"I Login into Turn Up Portal")]
        public void GivenILoginIntoTurnUpPortal()
        {
            _LoginPage.loginStep();
        }

        [When(@"I Click on ""(.*)"" under Administration Dropdown")]
        public void WhenIClickOnUnderAdministrationDropdown(string adminMenuOption)
        {
            _HomePage.NavigateToTM();  
        }

        [Then(@"I Verify that I am On Employee Page")]
        public void ThenIVerifyThatIAmOnEmployeePage()
        {
        }
    }
}
