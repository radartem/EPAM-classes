﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Framework.Driver;
using System.IO;
using NUnit.Framework.Interfaces;
using Framework.Utils;
using OpenQA.Selenium.Support.UI;
using log4net;

namespace Framework.Test
{
    public class CommonConditions
    {
        public IWebDriver webDriver;

        [SetUp]
        public void StartBrowserAndGoToTheSite()
        {
            Logger.InitLogger();
            Logger.Log.Warn("Start driver initializing.");
            webDriver = DriverSingleton.GetWebDriver();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            Logger.Log.Info("Driver initialized.");
        }

        [TearDown]
        public void ClearDriver()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                ScreenshotCreater.SaveScreenShot(webDriver);
                Logger.Log.Fatal("Test Failed");

            }

            DriverSingleton.CloseDriver();
            Logger.Log.Info("Driver Closed.");
        }

    }
}
