using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObject;

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
            webDriver.Quit();
        }

        [Test]
        public void StartDateLeaseEndDate()
        {
            string expectingMessage = "×\r\nДата начала аренды позже даты окончания.";
            StartPage startPage = new StartPage(webDriver);

            string errorMessage = startPage.SetDateStart(2)
                                            .SetDateEnd(-3)
                                            .ClickSubmitButton()
                                            .GetMessageText();
            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        public void SendBlankEMail()
        {
            string expectingMessage = "Поле 'E-mail' должно быть заполнено!\r\nПоле 'Тема' должно быть заполнено!\r\nПоле 'Ваше сообщение' должно быть заполнено!\r\nПодтвердите что вы не робот";

            ContactsPage contactsPage = new ContactsPage(webDriver);

            string errorMessage = contactsPage.GoToContactsPage(webDriver)
                                                .SendMessage(new Message())
                                                .GetMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        public void SendEMailIncorrectEMailAdr()
        {
            string expectingMessage = "Неправильный E-mail\r\nПодтвердите что вы не робот";

            Message message = new Message("Test topic", "testMail", "375298947333", "My message"); // fields "Тема", "E-mail","Номер","Сообщение"
            ContactsPage contactsPage = new ContactsPage(webDriver);

            string errorMessage = contactsPage.GoToContactsPage(webDriver)
                                                .SendMessage(message)
                                                .GetMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }
    }
}
