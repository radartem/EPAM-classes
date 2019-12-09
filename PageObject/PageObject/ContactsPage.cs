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

        [FindsBy(How = How.XPath, Using = "//a[@href='/info/']")]
        private IWebElement navigationMenuLinkContacts;

        [FindsBy(How = How.Name, Using = "PROPERTY[NAME][0]")]
        private IWebElement topicField;

        [FindsBy(How = How.Name, Using = "PROPERTY[PREVIEW_TEXT][0]")]
        private IWebElement previewTextField;

        [FindsBy(How = How.Name, Using = "PROPERTY[216][0]")]
        private IWebElement eMailField;

        [FindsBy(How = How.Name, Using = "PROPERTY[217][0]")]
        private IWebElement pNumberField;

        [FindsBy(How = How.Name, Using = "iblock_submit")]
        private IWebElement sendButton;

        [FindsBy(How = How.ClassName, Using = "errortext")]
        private IWebElement errorMessageAlert;

        public ContactsPage GoToContactsPage(IWebDriver webDriver)
        {
            navigationMenuLinkContacts.Click();
            return this;
        }
        public ContactsPage SendMessage(Message message)
        {
            topicField.SendKeys(message.Topic);
            previewTextField.SendKeys(message.MessageText);
            eMailField.SendKeys(message.Email);
            pNumberField.SendKeys(message.PNumber);

            return this;
        }

        public string GetMessageText()
        {
            return errorMessageAlert.Text;
        }

    }

}
