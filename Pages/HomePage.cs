using OpenQA.Selenium;
using SpecFlowAutomation.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowAutomation.Pages
{
    public class HomePage : BasePage
    {
        private string URL => "https://reqnroll.net/";
        private string mainMenuItemXpath => "//*[a/span[contains(text(),'{0}')]]"; //*[@id='modal-1-content']/ul/li[3]/a/span";
        private string documentationMenuItemXpath => "//*[@id='modal-1-content']/ul/li/a";

        private static HomePage _instance;
        public static HomePage Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HomePage();
                }
                return _instance;
            }
        }
        public void OpenReqnrollMainPage()
        {
            DriverManager.Instance().Navigate().GoToUrl(URL);
        }
         public void HoverOnMenuItem(string item)
        {
            var mainMenuItem = findElements(By.XPath(string.Format(mainMenuItemXpath,item))).First(x =>x.Text.Equals(item));
            OpenQA.Selenium.Interactions.Actions actions = new OpenQA.Selenium.Interactions.Actions(DriverManager.Instance());
            actions.MoveToElement(mainMenuItem).Perform();
        }
        public void ClickOnMenuItem(string item)
        {
            var mainMenuItem = findElements(By.XPath(documentationMenuItemXpath)).First();
            OpenQA.Selenium.Interactions.Actions actions = new OpenQA.Selenium.Interactions.Actions(DriverManager.Instance());
            actions.MoveToElement(mainMenuItem).Perform();
            actions.Click();
        }

    }
}
