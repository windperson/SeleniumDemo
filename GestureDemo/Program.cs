using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using BrowserAutomationLib;

namespace GestureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using IWebDriver driver = new ChromeDriver();

            NavigateDemo.DoBrowsing(driver);
            
            driver.Close();

            Console.WriteLine("done, press any key to close.");
            Console.ReadKey();
        }
    }
}
