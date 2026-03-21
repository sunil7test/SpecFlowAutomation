using OpenQA.Selenium;
using SpecFlowAutomation.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SpecFlowAutomation.Pages
{
    public class BasePage
    {
        private string headerXPath => "//*[@id='{0}']/h1/text()";

        private static BasePage basePage;
        public static BasePage Instance => basePage ?? (basePage = new BasePage());
        public BasePage() { }
        public IWebElement findElement(By locator) {
         return DriverManager.Instance().FindElement(locator);
        }
        public ReadOnlyCollection<IWebElement> findElements(By locator)
        {
            return DriverManager.Instance().FindElements(locator);
        } 
        public bool isDisplayed(By locator, int timeout)
        {
            try
            {
                var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(DriverManager.Instance(), TimeSpan.FromSeconds(timeout));
               return  wait.Until(driver => DriverManager.Instance().FindElement(locator).Displayed);
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        public bool isPageHeaderDisplayed(string headerText)
        {

            return isDisplayed(By.XPath(string.Format(headerXPath,headerText)), 30);
        }

    }
}
