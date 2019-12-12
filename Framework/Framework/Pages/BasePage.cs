﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver webDriver;
        public WebDriverWait Wait;

        public abstract BasePage OpenPage();
        protected BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
    }
}
