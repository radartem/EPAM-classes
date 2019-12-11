﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Framework.driver;
using System.IO;
using NUnit.Framework.Interfaces;
using Framework.Utils;

namespace Framework.Test
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
        public void ClearDriver()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                ScreenshotCreater.SaveScreenShot(webDriver);

            DriverSingleton.CloseDriver();
        }

    }
}
