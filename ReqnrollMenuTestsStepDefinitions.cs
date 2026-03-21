using System;
using NUnit.Framework;
using Reqnroll;
using SpecFlowAutomation.Base;
using SpecFlowAutomation.Pages;

namespace SpecFlowAutomation
{
    [Binding]
    public class ReqnrollMenuTestsStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;

        public ReqnrollMenuTestsStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("User opens reqnroll main page")]
        public void OpensReqnrollMainPage()
        {
            HomePage.Instance.OpenReqnrollMainPage();
        }

        [When("I hover on {string} menu item")]
        public void HoverOnDocumentationMenuItem(string menuItem)
        {
            HomePage.Instance.HoverOnMenuItem(menuItem);
        }

        [When("I click on {string} menu item")]
        public void ClickOnDocumentationMenuItem(string menuItem)
        {
           HomePage.Instance.ClickOnMenuItem(menuItem);
        }

        [Then("Page with {string} header should be opened")]
        public void PageWithHeaderShouldBeOpened(string header)
        {
            Assert.IsTrue(BasePage.Instance.isPageHeaderDisplayed(header), header + " is not found on the Documentation Page");

        }
        [AfterScenario]
        public static void AfterTestRun() {
            DriverManager.Quit();
        }

    }
}
