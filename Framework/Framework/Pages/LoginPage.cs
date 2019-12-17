using Framework.Model;
using Framework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class LoginPage : BasePage
    {
        [FindsBy(How = How.Name, Using = "LOGIN")]
        private IWebElement eMailField;
        [FindsBy(How = How.Name, Using = "PASSWORD")]
        private IWebElement passwordField;
        [FindsBy(How = How.ClassName, Using = "field-input-radio")]
        private IWebElement rememberMeRadioButton;
        [FindsBy(How = How.Name, Using = "login")]
        private IWebElement submitButtton;
        [FindsBy(How = How.ClassName, Using = "field-tips_error")]
        private IWebElement errorMessage;

        public LoginPage FillInFields(User user)
        {
            Logger.Log.Info("Fill in fields:" + user.ToString());

            eMailField.SendKeys(user.EMail);
            passwordField.SendKeys(user.Password);
            rememberMeRadioButton.Click();
            return this;
        }

        public LoginPage Login()
        {
            Logger.Log.Info("Login.");
            submitButtton.Click();
            return this;
        }

        public string GetErrorMessage()
        {
            try
            {
                Logger.Log.Info("Get message text: " + errorMessage.Text);

                return errorMessage.Text;
            }
            catch (WebDriverException wdEx)
            {
                Logger.Log.Info("Get message text: no error message" );
                return "";
            }
            catch (Exception ex)
            {
                Logger.Log.Info(ex.Message);
                return "";
            }
        }
        public override BasePage OpenPage()
        {
            Logger.Log.Info("Open login page.");

            webDriver.Navigate().GoToUrl("https://rentride.ru/login/?BACKURL=/account/cars/new/");
            return this;
        }
        public LoginPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
    }
}
