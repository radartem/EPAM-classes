using Framework.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Framework.Pages
{
    public class OrdersListPage : BasePage
    {
        [FindsBy(How = How.ClassName, Using = "card__more-link")]
        private IWebElement firstMoreInformationButton;
        
        [FindsBy(How = How.ClassName, Using = "filter-pane-footer__reset")]
        private IWebElement filterResetButton;

        [FindsBy(How = How.Id, Using = "filter-preloader")]
        private IWebElement submitFilterButton;
        
        [FindsBy(How = How.ClassName, Using = "car-list")]
        private IList<IWebElement> carList;

        [FindsBy(How = How.ClassName, Using = "driver-close-btn")]
        private IWebElement helpNotesCloseButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='notifies-block']/div")]
        private IWebElement errorMessageAlert;

        public override BasePage OpenPage()
        {
            throw new NotImplementedException();
        }

        public OrdersListPage(IWebDriver webDriver) : base(webDriver)
        {
            Logger.Log.Info("Open orders list page");
            PageFactory.InitElements(webDriver, this);
        }

        public OrdersListPage ResetFilters()
        {
            Logger.Log.Info("Reset filters");
            filterResetButton.Click();
            return this;
        }
        public OrdersListPage SubmitFilterOptions()
        {
            Logger.Log.Info("Submit filter options");

            submitFilterButton.Click();
            return this;
        }

        public bool IsCarListEmpty()
        {
            Logger.Log.Info("Cheak car list (count elements: " + carList.Count + ")");
            return carList.Count <= 0;
        }

        public InformationOfferPage TakeMoreInformationAboutFirstOrder()
        {
            Logger.Log.Info("Go to InformationOfferPage");
            firstMoreInformationButton.Click();
            return new InformationOfferPage(this.webDriver);
        }
        public string GetErrorMessageText()
        {
            Logger.Log.Info("Get error text: " + errorMessageAlert.Text);
            return errorMessageAlert.Text;
        }
        
    }
}
