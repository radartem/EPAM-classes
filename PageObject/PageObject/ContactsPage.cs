using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace PageObject
{
    public class ContactsPage
    {
        public ContactsPage(IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        [FindsBy(How = How.ClassName, Using = "nav-main__link")]
        private IWebElement navigationMenuLinkContacts { get; set; }

        [FindsBy(How = How.ClassName, Using = "field-input")]
        private IWebElement[] listOfFields { get; set; }

        [FindsBy(How = How.ClassName, Using = "field-input-textarea")]
        private IWebElement fieldMessage { get; set; }

        [FindsBy(How = How.Name, Using = "iblock_submit")]
        private IWebElement sendButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "errortext")]
        private IWebElement errorMessageAlert { get; set; }

        public ContactsPage GoToContactsPage(IWebDriver webDriver)
        {
            navigationMenuLinkContacts.Click();
            return this;
        }
        public ContactsPage SendMessage(string[] messageFields)
        {
            fromInputfields[0].SendKeys(messageFields[0]); //fielde "Тема"
            fromInputfields[1].SendKeys(messageFields[1]);    //field "Е-mail"
            fromInputfields[2].SendKeys(messageFields[2]); //field "Номер"
            fieldMessage.SendKeys(messageFields[3]); //field "Номер"

            return this;
        }

        public string GetMessageText()
        {
            return errorMessageAlert.Text;
        }

    }
}
