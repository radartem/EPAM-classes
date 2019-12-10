using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObject;
using PageObject.Test;

namespace SeleniumWebDriver
{
    [TestFixture]
    public class OrderTest : CommonConditions
    {
        [Test]
        public void StartDateLeaseEndDate()
        {
            string expectingMessage = "×\r\nДата начала аренды позже даты окончания.";
            StartPage startPage = new StartPage(webDriver);

            string errorMessage = (startPage.OpenPage() as StartPage)
                                            .SetDateStart(2)
                                            .SetDateEnd(-3)
                                            .ClickSubmitButton()
                                            .GetMessageText();
            Assert.AreEqual(expectingMessage, errorMessage);
        }

    }
}
