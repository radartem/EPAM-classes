using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace PageObject.driver
{
    public class DriverSingleton
    {
        private static IWebDriver webDriver;
        private DriverSingleton() { }
        
        public static IWebDriver GetWebDriver()
        {
            if(webDriver==null)
            {
                switch(TestContext.Parameters.Get("browser"))
                {
                    case "chrome":
                        webDriver = new ChromeDriver();
                        break;
                    case "edge":
                        webDriver = new EdgeDriver();
                        break;
                    case "firefox":
                        webDriver = new FirefoxDriver();
                        break;
                }

                webDriver.Manage().Window.Maximize();
            }

            return webDriver;
        }

        public static void closeDriver()
        {
            webDriver.Quit();
            webDriver = null;
        }
    }
}
