using System;
using OpenQA.Selenium;

namespace BrowserAutomationLib
{
    public static class NavigateDemo
    {
        public static void DoBrowsing(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(@"https://learn-automation.com");

            const string videoXpath = @"//*[text()='Selenium Videos']/..";
            driver.FindElement(By.XPath(videoXpath)).Click();

            driver.Navigate().Back();
            driver.Navigate().Forward();
            driver.Navigate().Refresh();
        }
    }
}