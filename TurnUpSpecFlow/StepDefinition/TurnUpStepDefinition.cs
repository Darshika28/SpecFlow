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
        private readonly TMPage _TMPage;
        //Constructor
        public TurnUpStepDefinition(IWebDriver driver)
        {
            _LoginPage = new LoginPage(driver);
            _HomePage = new HomePage(driver);
            _TMPage = new TMPage(driver);
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

        [Then(@"I Verify that I am On Time-Material Page")]
        public void ThenIVerifyThatIAmOnEmployeePage()
        {

            _TMPage.CheckIfTMPage();
        }


        [Given(@"Click on Create new button")]
        public void GivenClickOnCreateNewButton()
        {
        }

        [When(@"Create new record in Time Material Page")]
        public void WhenCreateNewRecordInTimeMaterialPage()
        {
            _TMPage.createTM();
        }

        [Then(@"I Verify that record is created")]
        public void ThenIVerifyThatRecordIsCreated()
        {
        }

    }
}
