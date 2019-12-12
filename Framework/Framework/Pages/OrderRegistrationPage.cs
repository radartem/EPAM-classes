using Framework.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class OrderRegistrationPage:BasePage
    {
        
        [FindsBy(How = How.ClassName, Using = "selection")]
        private IWebElement driveRigionList;

        [FindsBy(How = How.ClassName, Using = "select2-results__option")]
        private IWebElement firstElementDriveRigionList;

        [FindsBy(How = How.Id, Using = "NAME")]
        private IWebElement nameField;

        [FindsBy(How = How.Id, Using = "EXP_YEAR")]
        private IWebElement experienceField;

        [FindsBy(How = How.Id, Using = "PHONE")]
        private IWebElement pNumberField;

        [FindsBy(How = How.Id, Using = "EMAIL")]
        private IWebElement eMailField;

        [FindsBy(How = How.Id, Using = "rent-submit")]
        private IWebElement rentSubmitButton;

        [FindsBy(How = How.Id, Using = "notifies-block")]
        private IWebElement errorMessageAlert;

        public OrderRegistrationPage FillInUserData(User user)
        {
            nameField.SendKeys(user.Name);
            experienceField.SendKeys(user.Experience);
            pNumberField.SendKeys(user.PNumber);
            eMailField.SendKeys(user.EMail);
            return this;
        }

        public OrderRegistrationPage SubmitOrder()
        {
            rentSubmitButton.Click();
            return this;
        }
        public string GetErrorMessageText()
        {
            return errorMessageAlert.Text;
        }

        public OrderRegistrationPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public override BasePage OpenPage()
        {
            webDriver.Navigate().GoToUrl("https://rentride.ru/deal/38339620");
            return this;
        }
    }
}
