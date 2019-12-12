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
    public class InformatioOfferPage : BasePage
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
        public InformatioOfferPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }

        public OrderRegistrationPage SubmitOrderСhoice()
        {
            rentalButtonSubmit.Click();
            return new OrderRegistrationPage(this.webDriver);
        }

        public InformatioOfferPage SetDateStartFromDefault(int coutDays)
        {
            DateCalendarManipulater.SetDateCalendar(rentalDateStart, coutDays);

            return this;
        }
        public InformatioOfferPage SetDateEndFromDefault(int coutDays)
        {
            DateCalendarManipulater.SetDateCalendar(rentalDateEnd, coutDays);
            rentalDateEnd.SendKeys(Keys.Enter);
            
            return this;
        }
    }
}
