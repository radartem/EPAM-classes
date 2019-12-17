using Framework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class InformationOfferPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "rent_btn_submit")]
        private IWebElement rentalButtonSubmit;

        [FindsBy(How = How.Id, Using = "date_from")]
        private IWebElement rentalDateStart;

        [FindsBy(How = How.Id, Using = "date_to")]
        private IWebElement rentalDateEnd;

        public override BasePage OpenPage()
        {
            throw new NotImplementedException();
        }

        public InformationOfferPage(IWebDriver webDriver) : base(webDriver)
        {
            Logger.Log.Info("Open information Offer page.");

            PageFactory.InitElements(webDriver, this);
        }

        public OrderRegistrationPage SubmitOrderСhoice()
        {
            Logger.Log.Info("Submit order choice.");
            rentalButtonSubmit.Click();
            return new OrderRegistrationPage(this.webDriver);
        }

        public InformationOfferPage SetDateStartFromDefault(int coutDays)
        {
            Logger.Log.Info("Set date start from default: " + coutDays.ToString());

            DateCalendarManipulater.SetDateCalendar(rentalDateStart, coutDays);

            return this;
        }
        public InformationOfferPage SetDateEndFromDefault(int coutDays)
        {
            Logger.Log.Info("Set date end from default: " + coutDays.ToString());

            DateCalendarManipulater.SetDateCalendar(rentalDateEnd, coutDays);
            rentalDateEnd.SendKeys(Keys.Enter);
            
            return this;
        }
    }
}
