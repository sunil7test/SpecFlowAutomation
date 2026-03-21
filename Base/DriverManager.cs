using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowAutomation.Base
{
    public class DriverManager
    {
        public static ThreadLocal<IWebDriver> driver= new ThreadLocal<IWebDriver>();

        public static IWebDriver Instance()
        {
            if (driver.Value == null)
            {
                driver.Value = new ChromeDriver();
                driver.Value.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Value.Manage().Window.Maximize();
            }
            return driver.Value;
        }
        public static void Quit()
        {
            if (driver != null)
            {
                driver.Value.Quit();
                driver.Value = null;
            }
        }
    }
}
