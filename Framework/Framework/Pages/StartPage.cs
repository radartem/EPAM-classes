using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using Framework.Pages;
using Framework.Utils;
using Framework.Model;
using System.Threading;

namespace Framework
{
    public class StartPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[@href='/info/']")]
        private IWebElement navigationMenuLinkContacts;

        [FindsBy(How = How.Id, Using = "cars-filter-property-availability-date-begin")]
        private IWebElement rentalDateStart;

        [FindsBy(How = How.Id, Using = "cars-filter-property-availability-date-end")]
        private IWebElement rentalDateEnd;

        [FindsBy(How = How.Id, Using = "block-home-search_button-search")]
        private IWebElement submitButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='notifies-block']/div")]
        private IWebElement errorMessageAlert;

        public StartPage(IWebDriver webDriver):base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public StartPage SetDateStartFromDefault(int coutDays)
        {
            Logger.Log.Info("Set date start from default: " + coutDays.ToString());

            DateCalendarManipulater.SetDateCalendar(rentalDateStart, coutDays);

            return this;
        }
        public StartPage SetDateEndFromDefault(int coutDays)
        {
            Logger.Log.Info("Set date end from default: " + coutDays.ToString());

            DateCalendarManipulater.SetDateCalendar(rentalDateEnd, coutDays);

            return this;
        }

        public OrdersListPage ClickSubmitButton()
        {
            Logger.Log.Info("Submit filter (ClickSubmitButton)");
            submitButton.Click();
            return new OrdersListPage(this.webDriver);
        }

        public string GetErrorMessageText()
        {
            Logger.Log.Info("Get error text: " + errorMessageAlert.Text);
            return errorMessageAlert.Text;
        }
        
        public ContactsPage GoToContactsPage()
        {
            Logger.Log.Info("Go to contacts page");
            navigationMenuLinkContacts.Click();
            return new ContactsPage(this.webDriver);
        }

        public override BasePage OpenPage()
        {
            Logger.Log.Info("Open strat page.");
            webDriver.Navigate().GoToUrl("https://rentride.ru/");
            return this;
        }
    }
}
