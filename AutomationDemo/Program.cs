using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using BrowserAutomationLib;

namespace AutomationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin Google Chrome browser test.");
            using IWebDriver driver = new ChromeDriver();

            NavigateDemo.DoBrowsing(driver);
            
            driver.Close();

            Console.WriteLine("Test Done, press any key to close.");
            Console.ReadKey();
        }
    }
}
