using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObject;
using PageObject.Test;

namespace SeleniumWebDriver
{
    [TestFixture]
    public class ConsultationFormTest : CommonConditions
    {
        [Test]
        public void SendBlankEMail()
        {
            string expectingMessage = "Поле 'E-mail' должно быть заполнено!\r\nПоле 'Тема' должно быть заполнено!\r\nПоле 'Ваше сообщение' должно быть заполнено!\r\nПодтвердите что вы не робот";


            string errorMessage = (new StartPage(webDriver).OpenPage() as StartPage)
                                                .GoToContactsPage()
                                                .SendMessage()
                                                .GetMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }

        [Test]
        public void SendEMailIncorrectEMailAdr()
        {
            string expectingMessage = "Неправильный E-mail\r\nПодтвердите что вы не робот";

            Message message = new Message("Test topic", "testMail", "375298947333", "My message"); // fields "Тема", "E-mail","Номер","Сообщение"

            string errorMessage = (new StartPage(webDriver).OpenPage() as StartPage)
                                                .GoToContactsPage()
                                                .FillInFields(message)
                                                .SendMessage()
                                                .GetMessageText();

            Assert.AreEqual(expectingMessage, errorMessage);
        }

    }
}