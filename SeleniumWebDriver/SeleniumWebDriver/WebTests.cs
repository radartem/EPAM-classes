using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriver
{
    [TestFixture]
    public class WebTests 
    {
        public IWebDriver webDriver;

        [SetUp]
        public void StartBrowserAndGoToTheSite()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            webDriver.Navigate().GoToUrl("https://rentride.ru/");
        }

        [TearDown]
        public void QuitDriver()
        {
          //webDriver.Quit();
        }

        //[Test]
        //public void StartDateLeaseEndDate()
        //{
        //    var rentalDateStart = webDriver.FindElement(By.Id("cars-filter-property-availability-date-begin"));
        //    rentalDateStart.SendKeys(Keys.ArrowRight + Keys.ArrowRight); //defaulte rental start date + 2 days (defaulte rental start date = current date +1 day)

        //    var rentalDateEnd = webDriver.FindElement(By.Id("cars-filter-property-availability-date-end"));
        //    rentalDateEnd.SendKeys(Keys.ArrowLeft + Keys.ArrowLeft + Keys.ArrowLeft); //defaulte rental end date -3 days (default rental end date = current date + 4 days) 

        //    var submitButton = webDriver.FindElement(By.Id("block-home-search_button-search"));
        //    submitButton.Click();

        //    string errorMessage = webDriver.FindElement(By.XPath("//div[@id='notifies-block']/div")).Text;

        //    Assert.AreEqual("×\r\nДата начала аренды позже даты окончания.", errorMessage);
        //}

        //[Test]
        //public void SendBlankEMail()
        //{
        //    string expectingMessage = "Поле 'E-mail' должно быть заполнено!\r\nПоле 'Тема' должно быть заполнено!\r\nПоле 'Ваше сообщение' должно быть заполнено!\r\nПодтвердите что вы не робот";
        //    webDriver.FindElements(By.ClassName("nav-main__link"))[2].Click();

        //    var sendButton = webDriver.FindElement(By.Name("iblock_submit")); // navigation menu link "Контакты"
        //    sendButton.Click();

        //    webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

        //    string errorMessage = webDriver.FindElement(By.ClassName("errortext")).Text;
        //    Assert.AreEqual(expectingMessage, errorMessage);
        //}

        [Test]
        public void SendEMailIncorrectEMailAdr()
        {
            string expectingMessage = "Неправильный E-mail\r\nПодтвердите что вы не робот";
            
            webDriver.FindElements(By.ClassName("nav-main__link"))[2].Click(); // navigation menu link "Контакты"

            var fromInputfields = webDriver.FindElement(By.Name("PROPERTY[NAME][0]"));
            fromInputfields.SendKeys("Test topic"); //fielde "Тема"
            //fromInputfields[1].SendKeys("testMail");    //field "Е-mail"
            //fromInputfields[2].SendKeys("375298947333"); //field "Номер"

            //webDriver.FindElement(By.ClassName("field-input-textarea")).SendKeys("My message)"); //field "Ваше сообщение"

            //var sendButton = webDriver.FindElement(By.Name("iblock_submit"));
            //sendButton.Click();

            //webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);

            //string errorMessage = webDriver.FindElement(By.ClassName("errortext")).Text;
            //Assert.AreEqual(expectingMessage, errorMessage);
        }
    }
}
