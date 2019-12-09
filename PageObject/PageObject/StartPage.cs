using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject
{
    public class StartPage
    {
        [FindsBy(How = How.Id, Using = "cars-filter-property-availability-date-begin")]
        private IWebElement rentalDateStart;

        [FindsBy(How = How.Id, Using = "cars-filter-property-availability-date-end")]
        private IWebElement rentalDateEnd;

        [FindsBy(How = How.Id, Using = "block-home-search_button-search")]
        private IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='notifies-block']/div")]
        private IWebElement errorMessageAlert;

        public StartPage(IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public StartPage SetDateStart(int coutDays)
        {
            setDateCalendar(rentalDateStart, coutDays);

            return this;
        }
        public StartPage SetDateEnd(int coutDays)
        {
            setDateCalendar(rentalDateEnd, coutDays);

            return this;
        }

        private void setDateCalendar(IWebElement calendar, int days)
        {
            var keys = days > 0 ? Keys.ArrowRight : Keys.ArrowLeft;

            for (int i = 0; i < Math.Abs(days); i++)
                calendar.SendKeys(keys);
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
