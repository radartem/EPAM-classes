using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject
{
    public class StartPage
    {
        public StartPage(IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        [FindsBy(How = How.Id, Using = "cars-filter-property-availability-date-begin")]
        private IWebElement rentalDateStart { get; set; }

        [FindsBy(How = How.Id, Using = "cars-filter-property-availability-date-end")]
        private IWebElement rentalDateEnd { get; set; }

        [FindsBy(How = How.Id, Using = "block-home-search_button-search")]
        private IWebElement submitButton { get; set; }
      
        [FindsBy(How = How.XPath, Using = "//div[@id='notifies-block']/div")]
        private IWebElement errorMessageAlert { get; set; }
        
        public StartPage SetDateStart(int coutDays)
        {
            var keys = coutDays > 0 ? Keys.ArrowRight : Keys.ArrowLeft;

            for (int i = 0; i < Math.Abs(coutDays); i++)
                rentalDateStart.SendKeys(keys);

            return this;
        }
        public StartPage SetDateEnd(int coutDays)
        {
            var keys = coutDays > 0 ? Keys.ArrowRight : Keys.ArrowLeft;

            for (int i = 0; i < Math.Abs(coutDays); i++)
                rentalDateEnd.SendKeys(keys);

            return this;
        }

        public StartPage ClickSubmitButton()
        {
            submitButton.Click();
            return this;
        }

        public string GetMessageText()
        {
            return errorMessageAlert.Text;
        }
    }
}
