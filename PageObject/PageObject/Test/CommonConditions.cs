using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObject.driver;

namespace PageObject.Test
{
    public class CommonConditions
    {
        public IWebDriver webDriver;

        [SetUp]
        public void StartBrowserAndGoToTheSite()
        {
            webDriver = DriverSingleton.GetWebDriver();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }

        [TearDown]
        public void QuitDriver()
        {
            webDriver.Quit();
        }
    }
}
