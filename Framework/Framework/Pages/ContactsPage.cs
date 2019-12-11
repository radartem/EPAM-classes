using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using Framework.Pages;
using Framework.Model;

namespace Framework
{
    public class ContactsPage :BasePage
    {
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

        public ContactsPage FillInFields(Message message)
        {
            topicField.SendKeys(message.Topic);
            previewTextField.SendKeys(message.MessageText);
            eMailField.SendKeys(message.Email);
            pNumberField.SendKeys(message.PNumber);

            return this;
        }
        public ContactsPage SendMessage()
        {
            sendButton.Click();

            return this;
        }

        public string GetMessageText()
        {
            return errorMessageAlert.Text;
        }

        public override BasePage OpenPage()
        {
            webDriver.Navigate().GoToUrl("https://rentride.ru/info/");
            return this;
        }

        public ContactsPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

    }

}
